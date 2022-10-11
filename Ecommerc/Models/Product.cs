using Ecommerc.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace Ecommerc.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }	
		public string Description { get; set; }
		public double price { get; set; }
		public string IamgeURL { get; set; }
		public ProductColor productcolor { get; set; }
		// Naivgation propraty
		public int CategroyId { get; set; }
		[ForeignKey(nameof(CategroyId))]
		public Categroy Categroy { get; set; }
	}
}
