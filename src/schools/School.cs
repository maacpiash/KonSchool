using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KonSchool.Schools
{

	public class School
	{
		#region Must-have
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("EIIN")]
		public int EIIN { get; set; }
		[BsonElement("Name")]
		public string Name { get; set; }
		#endregion

		#region Age of School
		[BsonElement("Age")]
		public double OLD { get; set; }
		#endregion

		#region Location
		[BsonElement("Division")]
		public string Division { get; set; }
		[BsonElement("District")]
		public string District { get; set; }
		[BsonElement("Thana")]
		public string Thana { get; set; }
		[BsonElement("Union_Ward")]
		public string Union_Ward { get; set; }

		[BsonElement("MobileNum")]
		public string MobileNum { get; set; }

		[BsonElement("StreetAddr")]

		public string StreetAddr { get; set; }

		public double LOC { get; set; }
		#endregion

		#region Eligibility
		public string Type { get; set; } // boys'/girls'/co-ed
		public string Level { get; set; } // ju-sec/sec/hi-sec
		#endregion

		#region AverAge
		[BsonElement("AverAge6")]
		public double AverAge6 { get; set; }
		[BsonElement("AverAge7")]
		public double AverAge7 { get; set; }
		[BsonElement("AverAge8")]
		public double AverAge8 { get; set; }
		[BsonElement("AverAge9")]
		public double AverAge9 { get; set; }
		[BsonElement("AverAgeX")]
		public double AverAgeX { get; set; }

		private double[] averAge;

		public double[] AverAge
		{
			get
			{
				if (averAge == null)
					averAge = new double[] { AverAge6, AverAge7, AverAge8, AverAge9, AverAgeX };
				return averAge;
			}
			set
			{
				if (value.Length != 5)
					throw new Exception("Must have 5 values.");
				else
				{
					AverAge6 = value[0];
					AverAge7 = value[1];
					AverAge8 = value[2];
					AverAge9 = value[3];
					AverAgeX = value[4];
					averAge = value;
				}
			}
		}

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
		[BsonElement("SEScore1")]
		public double SEScore1 { get; set; }
		[BsonElement("SEScore2")]
		public double SEScore2 { get; set; }
		[BsonElement("SEScore3")]
		public double SEScore3 { get; set; }
		[BsonElement("SEScore4")]
		public double SEScore4 { get; set; }

		private double[] seScore;
		public double[] SEScore
		{
			get
			{
				if (seScore == null)
					seScore = new double[] { SEScore1, SEScore2, SEScore3, SEScore4 };
				return seScore;
			}
			set //=> seScore = value.Length == 4 ? value : null;
			{
				if (value.Length != 4)
					throw new Exception("Must have 4 values.");
				else
				{
					SEScore1 = value[0];
					SEScore2 = value[1];
					SEScore3 = value[2];
					SEScore4 = value[3];
					seScore = value;
				}
			}
		}

		// Stores Area-Score while reading from dataset. Will store actual SES after Query objct modifies the class instance.
		[BsonElement("Area")]
		public double SES { get; set; }
		#endregion

		#region Finalization
		public double[] WeightedScores { get; set; }

		public double FinalScore { get; internal set; }
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
}
