using System;
using System.Text.Json.Serialization;

namespace KonSchool.Lib
{

    public class School
    {
        #region Must-have
        [JsonPropertyName("ID")]
        public int EIIN { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        #endregion

        #region Age of School
        [JsonPropertyName("Age")]
        public double OLD { get; set; }
        #endregion

        #region Location
        [JsonPropertyName("Division")]
        public string Division { get; set; }
        [JsonPropertyName("District")]
        public string District { get; set; }
        [JsonPropertyName("Thana")]
        public string Thana { get; set; }
        [JsonPropertyName("Union_Ward")]
        public string Union_Ward { get; set; }

        [JsonPropertyName("MobileNum")]
        public string MobileNum { get; set; }

        [JsonPropertyName("StreetAddr")]

        public string StreetAddr { get; set; }
        
        [JsonIgnore]
        public double LOC { get; set; }
        #endregion

        #region Eligibility
        public string Type { get; set; } // boys'/girls'/co-ed
        public string Level { get; set; } // ju-sec/sec/hi-sec
        #endregion

        #region AverAge
        [JsonPropertyName("AverAge6")]
        public double AverAge6 { get; set; }
        [JsonPropertyName("AverAge7")]
        public double AverAge7 { get; set; }
        [JsonPropertyName("AverAge8")]
        public double AverAge8 { get; set; }
        [JsonPropertyName("AverAge9")]
        public double AverAge9 { get; set; }
        [JsonPropertyName("AverAgeX")]
        public double AverAgeX { get; set; }

        private double[] averAge;

        [JsonIgnore]
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
        [NotMapped]
        public double ADS { get; set; }
        #endregion

        #region Ratio
        [JsonPropertyName("MFRatio")]
        public double MFR { get; set; }
        [JsonPropertyName("TSRatio")]
        public double TSR { get; set; }

        #endregion

        #region Socio-Economic Status (SES)
        [JsonPropertyName("SEScore1")]
        public double SEScore1 { get; set; }
        [JsonPropertyName("SEScore2")]
        public double SEScore2 { get; set; }
        [JsonPropertyName("SEScore3")]
        public double SEScore3 { get; set; }
        [JsonPropertyName("SEScore4")]
        public double SEScore4 { get; set; }

        private double[] seScore;
        [NotMapped]
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
        [JsonPropertyName("Area")]
        public double SES { get; set; }
        #endregion

        #region Finalization
        [NotMapped]
        public double[] WeightedScores { get; set; }

        [NotMapped]
        public double FinalScore { get; internal set; }
        #endregion

        #region Ctor
        public School(int EIIN) => this.EIIN = EIIN;
        #endregion

        #region Optional
        [NotMapped]
        public bool EthnicStudents { get; set; }
        [NotMapped]
        public bool HasBusiness { get; set; }
        [NotMapped]
        public bool HasVocational { get; set; }
        #endregion
    }
}
