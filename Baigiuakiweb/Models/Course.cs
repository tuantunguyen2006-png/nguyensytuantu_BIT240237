
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baigiakiweb.Models
{
	public class Course
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Ten khoa hoc khong duoc de trong")]
		[StringLength(150)]
		public string Name { get; set; } = string.Empty;

		[Range(0.01, double.MaxValue,
			ErrorMessage = "Hoc phi phai lon hon 0")]
		[Column(TypeName = "decimal(18,2)")]
		public decimal TuitionFee { get; set; }

		[Range(1, int.MaxValue,
			ErrorMessage = "Thoi luong phai lon hon 0")]
		public int Duration { get; set; }

		public bool IsActive { get; set; } = true;

		public string? Description { get; set; }

		[Required]
		public int CourseCategoryId { get; set; }

		public CourseCategory? CourseCategory { get; set; }

		public ICollection<CourseImage> CourseImages { get; set; }
			= new List<CourseImage>();
	}
}
