namespace KonSchool.App.Models;

public class Location
{
	public string Division { get; set; }
	public string District { get; set; }
	public string Thana { get; set; }
	public string Union_Ward { get; set; }

	public Location(string div, string dis, string tu, string uw) => Update(div, dis, tu, uw);

	public Location() { }

	public void Update(string div, string dis, string tu, string uw)
	{
		Division = div;
		District = dis;
		Thana = tu;
		Union_Ward = uw;
	}
}
