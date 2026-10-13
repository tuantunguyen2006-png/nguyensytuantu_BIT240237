
using System.ComponentModel.DataAnnotations;

namespace Baigiakiweb.Models
{
	public class CourseImage
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Duong dan anh khong duoc de trong")]
		[StringLength(500)]
		public string ImageUrl { get; set; } = string.Empty;

		public bool IsThumbnail { get; set; } = false;

		[Required]
		public int CourseId { get; set; }

		public Course? Course { get; set; }
	}
}
