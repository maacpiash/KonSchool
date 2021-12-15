namespace KonSchool.App.Models;

public class Student
{
	public int Class { get; set; }
	public double Social { get; set; }
	public bool IsFemale { get; set; }
	public int Age { get; set; }
	public Location Address { get; set; }
	public string Occupation { get; set; }

	public Student() => Address = new Location();
}
