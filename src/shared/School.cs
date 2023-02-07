using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KonSchool.Shared;

public class School
{
	#region Must-have
	[BsonId]
	[BsonRepresentation(BsonType.ObjectId)]
	public string Id { get; set; }
	public int EIIN { get; set; }
	public string Name { get; set; }
	#endregion

	#region Age of School
	[BsonElement("Age")]
	public double OLD { get; set; }
	#endregion

	#region Location
	public string Division { get; set; }
	public string District { get; set; }
	public string Thana { get; set; }
	public string Union_Ward { get; set; }
	public string MobileNum { get; set; }
	public string StreetAddr { get; set; }
	public double LOC { get; set; }
	#endregion

	#region Eligibility
	public string Type { get; set; } // boys'/girls'/co-ed
	public string Level { get; set; } // ju-sec/sec/hi-sec
	#endregion

	#region AverAge
	public double AverAge6 { get; set; }
	public double AverAge7 { get; set; }
	public double AverAge8 { get; set; }
	public double AverAge9 { get; set; }
	public double AverAgeX { get; set; }

	// Actual age difference, stored when Query objct modifies the class instance.
	public double ADS { get; set; }
	#endregion

	#region Ratio
	[BsonElement("MFRatio")]
	public double MFR { get; set; }
	[BsonElement("TSRatio")]
	public double TSR { get; set; }

	#endregion

	#region Socio-Economic Status (SES)
	public double SEScore1 { get; set; }
	public double SEScore2 { get; set; }
	public double SEScore3 { get; set; }
	public double SEScore4 { get; set; }

	// Stores Area-Score while reading from dataset. Will store actual SES after Query objct modifies the class instance.
	[BsonElement("Area")]
	public double SES { get; set; }
	#endregion

	#region Finalization
	public double[] WeightedScores { get; set; }

	public double FinalScore { get; set; }
	#endregion

	#region Ctor
	public School(int EIIN) => this.EIIN = EIIN;
	#endregion

	#region Optional
	public bool EthnicStudents { get; set; }
	public bool HasBusiness { get; set; }
	public bool HasVocational { get; set; }
	#endregion
}
