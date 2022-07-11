using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestApply.Pages.Edit
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string orderDescription { get; set; }
        public void OnGet()
        {
        }

        public void OnPost(){
            if(orderDescription != null){
                int newId;
                if(Global.lstOrder.Count() > 0){
                    newId = Global.lstOrder.Max(x => x.IdOrder) + 1;
                }else{
                    newId = 1;
                }
                Global.lstOrder.Add(
                    new Models.Order {
                        IdOrder = newId,
                        Description = orderDescription,
                        IdStatus = 1
                    }
                );
            }

            Response.Redirect("/");
        }
    }
}
