using CapstoneBackEndAPI.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CapstoneBackendAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/main")]
    public class MainController : Controller
    {
        /*public JsonResult postFunction([FromBody] GoogleVisionViewModel nameModel)
        {
            var model = nameModel;
            
            return Json(new { response = model.CallGoogleVisionAPI() });
        }*/
        [HttpPost]
        [Route("post")]
        [EnableCors("DefaultPolicy")]
        public ActionResult Post([FromForm] GoogleVisionViewModel file)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
                using (Stream stream = new FileStream(path, FileMode.Create))
                {
                    file.FormFile.CopyTo(stream);
                }

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }



    }
}