using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class MarkaController : Controller
	{
		private List<Marka> _markas;

		public MarkaController()
		{
			_markas = new()
			{
				new() { Id = 1, MarkaName = "AUDI"},
				new() { Id = 2, MarkaName = "BMW"},
				new() { Id = 3, MarkaName = "LADA"},
				new() { Id = 4, MarkaName = "MERCEDES"},
				new() { Id = 5, MarkaName = "LEXUS"}
			};

		}

		public IActionResult Index()
		{
			return View(_markas);
		}
	}
}