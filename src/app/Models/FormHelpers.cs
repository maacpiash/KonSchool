namespace KonSchool.App.Models;

public static class FormHelpers
{
	public static void Merge(this AppStateContainer state, StudentFormModel inputs)
	{
		state.Student = new Student
		{
			Class = inputs.Class,
			IsFemale = inputs.IsFemale,
			Age = inputs.Age,
			Occupation = inputs.Occupation,
			Address = new Location(inputs.Division, inputs.District, inputs.Thana, inputs.Union_Ward)
		};
	}
}
