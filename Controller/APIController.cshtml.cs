using Microsoft.AspNetCore.Mvc;

namespace TestApply.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        [HttpPost]
        [Route("ChangeStatus/{idItem}")]
        public bool ChangeStatus(int idItem)
        {
            try
            {
                foreach(var item in Global.lstOrder.Where(x => x.IdOrder == idItem)){
                    if(item.IdStatus == 1) { item.IdStatus = 2; }
                    else if(item.IdStatus == 2) { item.IdStatus = 3; }
                }

                return true;
            }
            catch (System.Exception ex)
            {
                Response.StatusCode = 520;
                Response.WriteAsJsonAsync("Server Error: " + ex.Message);
                return false;
            }
        }

        [HttpPost]
        [Route("DeleteOrder/{idItem}")]
        public bool DeleteOrder(int idItem)
        {
            try
            {
                Global.lstOrder.Remove(Global.lstOrder.Where(x => x.IdOrder == idItem).FirstOrDefault());

                return true;
            }
            catch (System.Exception ex)
            {
                Response.StatusCode = 520;
                Response.WriteAsJsonAsync("Server Error: " + ex.Message);
                return false;
            }
        }

    }
}
