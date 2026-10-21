
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Baigiakiweb.Data;
using Baigiakiweb.Models;

namespace Baigiakiweb.Controllers
{
	public class DishesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public DishesController(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var dishes = await _context.Dishes_BIT240237
				.Include(d => d.DishCategory)
				.Include(d => d.DishImages)
				.ToListAsync();

			return View(dishes);
		}
	}
}
