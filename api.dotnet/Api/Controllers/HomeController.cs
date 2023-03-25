using Microsoft.AspNetCore.Mvc;

using System;

namespace Api.Controllers
{
	[Controller]
	public partial class HomeController : Controller
	{
		public HomeController(IServiceProvider serviceProvider)
		{
			ServiceProvider = serviceProvider;
		}

		protected IServiceProvider ServiceProvider { get; }

		[HttpGet("/")]
		[HttpGet(Routes.Home)]
		public IActionResult Index()
		{
			return View();
		}
	}
}
