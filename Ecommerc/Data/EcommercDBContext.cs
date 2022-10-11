using Ecommerc.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerc.Data
{
	public class EcommercDBContext:DbContext
	{
		public EcommercDBContext(DbContextOptions<EcommercDBContext>options):base(options)	
		{

		}
		public DbSet<Categroy> categroys { get; set; }
		public DbSet<Product> products { get; set; }
	}
}
