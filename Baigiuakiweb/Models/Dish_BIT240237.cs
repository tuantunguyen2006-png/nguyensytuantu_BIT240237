
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baigiakiweb.Models
{
	[Table("BIT240237_Dishes")]
	public class Dish_BIT240237
	{
		[Key]
		[Column("BIT240237_Id")]
		public int Id { get; set; }

		[Required(ErrorMessage = "Dish name is required.")]
		[StringLength(150)]
		[Column("BIT240237_Name")]
		public string Name { get; set; } = string.Empty;

		[Range(0.01, 1000000000)]
		[Column("BIT240237_Price")]
		public decimal Price { get; set; }

		[Range(1, 1440)]
		[Column("BIT240237_PreparationTime")]
		public int PreparationTime { get; set; }

		[Column("BIT240237_IsAvailable")]
		public bool IsAvailable { get; set; } = true;

		[Column("BIT240237_Description")]
		public string? Description { get; set; }

		[Column("BIT240237_DishCategoryId")]
		public int DishCategoryId { get; set; }

		[ForeignKey(nameof(DishCategoryId))]
		public DishCategory_BIT240237? DishCategory { get; set; }

		public ICollection<DishImage_BIT240237> DishImages { get; set; }
			= new List<DishImage_BIT240237>();

		[NotMapped]
		public string PreparationType =>
			PreparationTime <= 15 ? "Quick" : "Regular";
	}
}
