using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestApply.Models;

namespace TestApply.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int? orderFilter { get; set; }
        
        [BindProperty]
        public int? statusFilter { get; set; }
        public List<Order> lstOrderView { get; set; }
        public void OnGet()
        {
            if(Global.lstOrder == null){
                Global.lstOrder = new List<Order>(){
                    new Order { IdOrder = 1, Description = "Order 1", IdStatus = 1 },
                    new Order { IdOrder = 2, Description = "Order 2", IdStatus = 1 },
                    new Order { IdOrder = 3, Description = "Order 3", IdStatus = 1 },
                };
            }
            LoadData();   
        }

        public void LoadData(){
            lstOrderView = Global.lstOrder;
        }

        public void OnPost(){
            LoadData();
            IQueryable<Order> query = Global.lstOrder.AsQueryable(); 
            if(orderFilter != null){
                query = query.Where(x => x.IdOrder == orderFilter);
            }

            if(statusFilter != null){
                query = query.Where(x => x.IdStatus == statusFilter);
            }

            lstOrderView = query.ToList();
        }
    }
}
