using System.ComponentModel.DataAnnotations;

namespace Ecommerc.Models
{
	public class Categroy
	{
		public Categroy()
		{
			products = new HashSet<Product>();
		}

		[Key]
		public  int id { get; set; }
		public string Name  { get; set; }
		public string Description { get; set; }
		// Navigational propery
		public ICollection<Product> products { get; set; }
	}
}
