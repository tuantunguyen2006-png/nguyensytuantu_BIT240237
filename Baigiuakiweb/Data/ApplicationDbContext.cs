
using Baigiakiweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Baigiakiweb.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(
			DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Course> Courses { get; set; }
		public DbSet<CourseCategory> CourseCategories { get; set; }
		public DbSet<CourseImage> CourseImages { get; set; }

		public DbSet<Dish_BIT240237> Dishes_BIT240237 { get; set; }
		public DbSet<DishCategory_BIT240237> DishCategories_BIT240237 { get; set; }
		public DbSet<DishImage_BIT240237> DishImages_BIT240237 { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Dish_BIT240237>()
				.ToTable("Dishes_BIT240237");

			modelBuilder.Entity<DishCategory_BIT240237>()
				.ToTable("DishCategories_BIT240237");

			modelBuilder.Entity<DishImage_BIT240237>()
				.ToTable("DishImages_BIT240237");
		}
	}
}
