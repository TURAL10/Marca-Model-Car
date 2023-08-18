using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class CarController : Controller
	{
		private List<Car> _cars;

		public CarController()
		{
			_cars = new()
			{
				new () { Id = 1, CarName="AUDI S5", ModelId= 1 },
				new () { Id = 2, CarName="AUDI S6", ModelId= 1 },
				new () { Id = 3, CarName="AUDI SQ7", ModelId= 1 },
				new () { Id = 4, CarName="AUDI TT RS", ModelId= 2 },
				new () { Id = 5, CarName="AUDI RS Q3", ModelId= 2 },
				new () { Id = 6, CarName="AUDI RS7", ModelId= 2 },
				new () { Id = 7, CarName="AUDI R8", ModelId= 3 },
				new () { Id = 8, CarName="AUDI A7", ModelId= 3 },
				new () { Id = 9, CarName="AUDI Q8", ModelId= 3 },
				new () { Id = 10, CarName="BMW M3", ModelId= 4 },
				new () { Id = 11, CarName="BMW X5 M", ModelId= 4 },
				new () { Id = 12, CarName="BMW XM", ModelId= 4 },
				new () { Id = 13, CarName="BMW X1", ModelId= 5 },
				new () { Id = 14, CarName="BMW X5", ModelId= 5 },
				new () { Id = 15, CarName="BMW X7", ModelId= 5 },
				new () { Id = 16, CarName="BMW i3", ModelId= 6 },
				new () { Id = 17, CarName="BMW i7", ModelId= 6 },
				new () { Id = 18, CarName="BMW iX", ModelId= 6 },
				new () { Id = 19, CarName="LADA 2101", ModelId= 7 },
				new () { Id = 20, CarName="LADA 2106", ModelId= 7 },
				new () { Id = 21, CarName="LADA 2107", ModelId= 7 },
				new () { Id = 22, CarName="LADA Niva", ModelId= 8 },
				new () { Id = 23, CarName="LADA Oka", ModelId= 8 },
				new () { Id = 24, CarName="LADA Priora", ModelId= 8 },
				new () { Id = 25, CarName="LADA VESTA Cross", ModelId= 9 },
				new () { Id = 26, CarName="LADA VESTA SW", ModelId= 9 },
				new () { Id = 27, CarName="LADA VESTA SW Cross", ModelId= 9 },
				new () { Id = 28, CarName="MERCEDES A 140", ModelId= 10 },
				new () { Id = 29, CarName="MERCEDES A 200", ModelId= 10 },
				new () { Id = 30, CarName="MERCEDES A 250e", ModelId= 10 },
				new () { Id = 31, CarName="MERCEDES C 160", ModelId= 11 },
				new () { Id = 32, CarName="MERCEDES C 280", ModelId= 11 },
				new () { Id = 33, CarName="MERCEDES C 300e", ModelId= 11 },
				new () { Id = 34, CarName="MERCEDES S 450", ModelId= 12 },
				new () { Id = 35, CarName="MERCEDES S 580 4Matic", ModelId= 12 },
				new () { Id = 36, CarName="MERCEDES S 63 AMG", ModelId= 12 },
				new () { Id = 37, CarName="LEXUS LX 500d", ModelId= 13 },
				new () { Id = 38, CarName="LEXUS LX 570", ModelId= 13 },
				new () { Id = 39, CarName="LEXUS LX 600", ModelId= 13 },
				new () { Id = 40, CarName="LEXUS NX 200t", ModelId= 14 },
				new () { Id = 41, CarName="LEXUS NX 300h", ModelId= 14 },
				new () { Id = 42, CarName="LEXUS NX 350h", ModelId= 14 },
				new () { Id = 43, CarName="LEXUS RX 350h", ModelId= 15 },
				new () { Id = 44, CarName="LEXUS RX 400h", ModelId= 15 },
				new () { Id = 45, CarName="LEXUS RX 450h", ModelId= 15 }
			};
		}




		public IActionResult Index(int? id)
		{
			if (id == 0) return View(_cars);
			if (_cars.Exists(c => c.ModelId == id))
			{
				return View(_cars.FindAll(c => c.ModelId == id));
			}

			return NotFound();
		}
	}
}
