using Ecommerc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerc.Controllers
{
	public class ProductController1 : Controller
	{
		private readonly EcommercDBContext _Context;
		public ProductController1(EcommercDBContext context)
		{
			_Context = context;
		}

		public async Task <IActionResult> Index()
		{
			var respones =await _Context.products.ToListAsync();
			return View(respones);
		}
	}
}
