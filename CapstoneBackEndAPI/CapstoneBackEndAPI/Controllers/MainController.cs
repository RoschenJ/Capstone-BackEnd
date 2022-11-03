using CapstoneBackEndAPI.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CapstoneBackendAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/main")]
    public class MainController : Controller
    {
        [HttpPost]
        [Route("post")]
        [EnableCors("DefaultPolicy")]
        public JsonResult postFunction([FromBody] GoogleVisionViewModel nameModel)
        {
            var model = nameModel;
            
            return Json(new { response = model.CallGoogleVisionAPI() });
        }
        



    }
}