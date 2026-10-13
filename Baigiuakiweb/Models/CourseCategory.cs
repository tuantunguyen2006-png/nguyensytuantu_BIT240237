
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Baigiakiweb.Models
{
	public class CourseCategory
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Ten loai khoa hoc khong duoc de trong")]
		[StringLength(100)]
		public string Name { get; set; } = string.Empty;

		public string? Description { get; set; }

		public ICollection<Course> Courses { get; set; }
			= new List<Course>();
	}
}
