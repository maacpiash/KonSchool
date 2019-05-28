using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KonSchool.Models
{

    public class School
    {
        #region Must-have
        public int EIIN { get; set; }
        public string Name { get; set; }
        #endregion

        #region Age of School
        public double OLD { get; set; }
        #endregion

        #region Location
        public string Division { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }
        public string Union_Ward { get; set; }

        private string mobilenum;
        public string MobileNum
        {
            get => mobilenum;
            set => mobilenum = value.Contains("+880") ? (value) : (value.StartsWith("0") ? "+88" + value : "+880" + value);
        }
        public string StreetAddr { get; set; }
        
        [NotMapped]
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

        private double[] averAge;

        [NotMapped]
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
        public double AGE { get; set; }
        #endregion

        #region Ratio
        public double MFR { get; set; }
        public double TSR { get; set; }

        #endregion

        #region Socio-Economic Status (SES)
        public double SEScore1 { get; set; }
        public double SEScore2 { get; set; }
        public double SEScore3 { get; set; }
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
        public bool EthnicStudents { get; set; }
        public bool HasBusiness { get; set; }
        public bool HasVocational { get; set; }
        #endregion
    }
}
