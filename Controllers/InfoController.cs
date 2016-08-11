using Microsoft.AspNetCore.Mvc;

namespace ServiceA.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Get()
        {
            return Json(new
            {
                service = "a",
                test = true
            });
        }
    }
}
