
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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Course>()
				.HasIndex(c => new { c.CourseCategoryId, c.Name })
				.IsUnique();

			modelBuilder.Entity<CourseCategory>()
				.HasMany(c => c.Courses)
				.WithOne(c => c.CourseCategory)
				.HasForeignKey(c => c.CourseCategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<Course>()
				.HasMany(c => c.CourseImages)
				.WithOne(i => i.Course)
				.HasForeignKey(i => i.CourseId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
