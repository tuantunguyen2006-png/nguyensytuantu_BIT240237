
using Baigiakiweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Baigiakiweb.Data
{
	public static class DbInitializer
	{
		public static async Task SeedAsync(ApplicationDbContext context)
		{
			if (!await context.CourseCategories.AnyAsync())
			{
				context.CourseCategories.AddRange(
					new CourseCategory
					{
						Name = "Lap trinh Web",
						Description = "Cac khoa hoc phat trien web"
					},
					new CourseCategory
					{
						Name = "Lap trinh Ung dung",
						Description = "Cac khoa hoc lap trinh ung dung"
					},
					new CourseCategory
					{
						Name = "Tri tue nhan tao",
						Description = "Cac khoa hoc AI va Machine Learning"
					}
				);

				await context.SaveChangesAsync();
			}

			if (!await context.Courses.AnyAsync())
			{
				var categories = await context.CourseCategories
					.ToDictionaryAsync(c => c.Name, c => c.Id);

				context.Courses.AddRange(
					new Course
					{
						Name = "ASP.NET Core MVC",
						TuitionFee = 2500000,
						Duration = 24,
						IsActive = true,
						Description = "Xay dung website voi ASP.NET Core MVC",
						CourseCategoryId = categories["Lap trinh Web"]
					},
					new Course
					{
						Name = "ReactJS",
						TuitionFee = 3000000,
						Duration = 36,
						IsActive = true,
						Description = "Xay dung giao dien web voi ReactJS",
						CourseCategoryId = categories["Lap trinh Web"]
					},
					new Course
					{
						Name = "Java OOP",
						TuitionFee = 1800000,
						Duration = 20,
						IsActive = false,
						Description = "Lap trinh huong doi tuong voi Java",
						CourseCategoryId = categories["Lap trinh Ung dung"]
					},
					new Course
					{
						Name = "Python Co ban",
						TuitionFee = 1500000,
						Duration = 18,
						IsActive = true,
						Description = "Nhap mon lap trinh Python",
						CourseCategoryId = categories["Lap trinh Ung dung"]
					},
					new Course
					{
						Name = "Machine Learning",
						TuitionFee = 4500000,
						Duration = 48,
						IsActive = true,
						Description = "Nhap mon hoc may",
						CourseCategoryId = categories["Tri tue nhan tao"]
					}
				);

				await context.SaveChangesAsync();
			}
		}
	}
}
