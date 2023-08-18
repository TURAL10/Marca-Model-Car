namespace WebApplication1.Models
{
	public class Model
	{
		public int Id { get; set; }

		public string ModelName { get; set; }

		public int MarkaId { get; set; }

		public Marka Marka { get; set; }

		public List<Car> Models { get; set; }
	}
}
