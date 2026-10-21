
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baigiakiweb.Models
{
	[Table("BIT240237_DishImages")]
	public class DishImage_BIT240237
	{
		[Key]
		[Column("BIT240237_Id")]
		public int Id { get; set; }

		[Required]
		[StringLength(500)]
		[Column("BIT240237_ImageUrl")]
		public string ImageUrl { get; set; } = string.Empty;

		[Column("BIT240237_IsThumbnail")]
		public bool IsThumbnail { get; set; }

		[Column("BIT240237_DishId")]
		public int DishId { get; set; }

		[ForeignKey(nameof(DishId))]
		public Dish_BIT240237? Dish { get; set; }
	}
}
