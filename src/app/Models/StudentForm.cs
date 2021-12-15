using System.ComponentModel.DataAnnotations;

namespace KonSchool.App.Models;

public class StudentFormModel
{
	[Required]
	[Range(6, 10, ErrorMessage = "{0} must be between {1} and {2}.")]
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

	[Required]
	[Range(1, 100, ErrorMessage = "{0} must be between {1} and {2}.")]
	public int Age { get; set; }

	[Required]
	public bool IsFemale { get; set; }

	[Required]
	public string Occupation { get; set; }

	[Required]
	public string Division { get; set; }

	[Required]
	public string District { get; set; }

	[Required(ErrorMessage = "The Thana/Upazilla field is required.")]
	public string Thana { get; set; }

	[Required(ErrorMessage = "The Union/Ward field is required.")]
	public string Union_Ward { get; set; }

	public void Deconstruct(out string div, out string dis, out string thana, out string uw)
	{
		div = Division;
		dis = District;
		thana = Thana;
		uw = Union_Ward;
	}
}
