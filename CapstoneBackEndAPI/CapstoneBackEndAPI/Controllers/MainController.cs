using CapstoneBackendAPI.ViewModels;
using CapstoneBackEndAPI.ViewModels;
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
        public JsonResult getFunction([FromBody] GoogleVisionViewModel nameModel)
        {
            var model = nameModel;
            model.CallGoogleVision();
            return Json(new { success = true });
        }
        



    }
}