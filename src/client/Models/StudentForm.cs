using System.ComponentModel.DataAnnotations;

namespace KonSchool.Client.Models
{
	public class StudentFormModel
	{
		[Required] [Range(6, 10, ErrorMessage = "Class {0} must be between {1} and {2}.")]
		public int Class
		{
			get => _class;
			set
			{
				_class = value;
				if (Age == 0) Age = _class + 5;
			}
		}
		private int _class;

		[Required] [Range(1, 100, ErrorMessage = "Age {0} must be between {1} and {2}.")]
		public int Age { get; set; }

		[Required]
		public bool IsFemale { get; set; }

		[Required]
		public string Occupation { get; set; }

		[Required]
		public string Division { get; set; }

		[Required]
		public string District { get; set; }

		[Required]
		public string Thana { get; set; }

		[Required]
		public string Union_Ward { get; set; }

	}
}
