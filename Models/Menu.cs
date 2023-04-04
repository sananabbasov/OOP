using System;
namespace Claasses.Models
{
	public class Menu
	{
		public string Name { get; set; }
		public decimal Price;
		public int Portion;
		public string PhotoUrl = "img/default.jpg";
		public DateTime CreatedDate = DateTime.Now;
		public string Description;



		public double GetTax()
		{
			return (double)Price * 0.14;
		}

	}
}

