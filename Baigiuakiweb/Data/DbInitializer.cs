
using Baigiakiweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Baigiakiweb.Data
{
	public static class DbInitializer
	{
		public static async Task SeedAsync(ApplicationDbContext context)
		{
			await context.Database.EnsureCreatedAsync();

			// 1. Them danh muc khoa hoc
			if (!await context.CourseCategories.AnyAsync())
			{
				context.CourseCategories.AddRange(
					new CourseCategory
					{
						Name = "Lap trinh"
					},
					new CourseCategory
					{
						Name = "Cong nghe thong tin"
					},
					new CourseCategory
					{
						Name = "Tri tue nhan tao"
					}
				);

				await context.SaveChangesAsync();
			}

			// 2. Lay danh muc khoa hoc
			var courseCategories = await context.CourseCategories
				.ToDictionaryAsync(c => c.Name, c => c.Id);

			// 3. Them khoa hoc
			if (!await context.Courses.AnyAsync())
			{
				context.Courses.AddRange(
					new Course
					{
						Name = "C# co ban",
						TuitionFee = 2000000,
						Duration = 24,
						IsActive = true,
						Description = "Nhap mon lap trinh C#",
						CourseCategoryId = courseCategories["Lap trinh"]
					},
					new Course
					{
						Name = "Machine Learning",
						TuitionFee = 4500000,
						Duration = 48,
						IsActive = true,
						Description = "Nhap mon hoc may",
						CourseCategoryId = courseCategories["Tri tue nhan tao"]
					}
				);

				await context.SaveChangesAsync();
			}

			// 4. Them danh muc mon an
			if (!await context.DishCategories_BIT240237.AnyAsync())
			{
				context.DishCategories_BIT240237.AddRange(
					new DishCategory_BIT240237
					{
						Name = "Mon chinh"
					},
					new DishCategory_BIT240237
					{
						Name = "Do uong"
					},
					new DishCategory_BIT240237
					{
						Name = "Trang mieng"
					}
				);

				await context.SaveChangesAsync();
			}

			// 5. Lay danh muc mon an
			var categories = await context.DishCategories_BIT240237
				.ToDictionaryAsync(c => c.Name, c => c.Id);

			// 6. Them du lieu mon an
			if (!await context.Dishes_BIT240237.AnyAsync())
			{
				context.Dishes_BIT240237.AddRange(
					new Dish_BIT240237
					{
						Name = "Pho bo",
						Price = 50000,
						PreparationTime = 15,
						IsAvailable = true,
						Description = "Pho bo truyen thong",
						DishCategoryId = categories["Mon chinh"]
					},
					new Dish_BIT240237
					{
						Name = "Bun cha",
						Price = 45000,
						PreparationTime = 20,
						IsAvailable = true,
						Description = "Bun cha Ha Noi",
						DishCategoryId = categories["Mon chinh"]
					},
					new Dish_BIT240237
					{
						Name = "Goi cuon",
						Price = 30000,
						PreparationTime = 10,
						IsAvailable = true,
						Description = "Goi cuon tuoi",
						DishCategoryId = categories["Mon chinh"]
					}
				);

				await context.SaveChangesAsync();
			}
		}
	}
}
