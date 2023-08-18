using System.Reflection;

namespace WebApplication1.Models
{
	public class Car
	{
		public int Id { get; set; }

		public string CarName { get; set; }

		public int ModelId { get; set; }

		public Model Model { get; set; }
	}
}
