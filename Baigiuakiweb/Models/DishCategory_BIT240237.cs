
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baigiakiweb.Models
{
	[Table("BIT240237_DishCategories")]
	public class DishCategory_BIT240237
	{
		[Key]
		[Column("BIT240237_Id")]
		public int Id { get; set; }

		[Required(ErrorMessage = "Category name is required.")]
		[StringLength(100)]
		[Column("BIT240237_Name")]
		public string Name { get; set; } = string.Empty;

		[Column("BIT240237_Description")]
		public string? Description { get; set; }

		public ICollection<Dish_BIT240237> Dishes { get; set; }
			= new List<Dish_BIT240237>();
	}
}
