using Ecommerc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerc.Controllers
{
	public class CategroiesController1 : Controller
	{
		private readonly EcommercDBContext _Context;
		public CategroiesController1(EcommercDBContext context)
		{
			_Context = context;
		}

		public async Task < IActionResult> Index()
		{
			var respones =await _Context.categroys.ToListAsync();	

			return View(respones);
		}
	}
}
