using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class ModelController : Controller
	{
		private List<Model> _models;

		public ModelController()
		{
			_models = new()
			{
				new() {Id=1, ModelName="AUDI S-series",MarkaId=1},
				new() {Id=2, ModelName="AUDI RS-series",MarkaId=1},
				new() {Id=3, ModelName="AUDI other-series",MarkaId=1},
				new() {Id=4, ModelName="BMW M-series",MarkaId=2},
				new() {Id=5, ModelName="BMW X-series",MarkaId=2},
				new() {Id=6, ModelName="BMW i-series",MarkaId=2},
				new() {Id=7, ModelName="LADA Sovet",MarkaId=3},
				new() {Id=8, ModelName="LADA Largus",MarkaId=3},
				new() {Id=9, ModelName="LADA Vesta",MarkaId=3},
				new() {Id=10, ModelName="MERCEDES A-class",MarkaId=4},
				new() {Id=11, ModelName="MERCEDES C-class",MarkaId=4},
				new() {Id=12, ModelName="MERCEDES S-class",MarkaId=4},
				new() {Id=13, ModelName="LEXUS LX-series",MarkaId=5},
				new() {Id=14, ModelName="LEXUS NX-series",MarkaId=5},
				new() {Id=15, ModelName="LEXUS RX-series",MarkaId=5}
			};
		}
		public IActionResult Index(int? id)
		{
			if (id == 0) return View(_models);
			if (_models.Exists(x => x.MarkaId == id))
			{
				return View(_models.FindAll(x => x.MarkaId == id));
			}

			return NotFound();
		}

	
	}
}
