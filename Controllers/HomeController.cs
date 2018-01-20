using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace survey_proj.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}