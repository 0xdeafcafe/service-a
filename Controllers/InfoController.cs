using Microsoft.AspNetCore.Mvc;

namespace ServiceA.Controllers
{
	public class InfoController : Controller
	{
		public IActionResult Index()
		{
			return Json(new
			{
				service = "a",
				test = true
			});
		}
	}
}
