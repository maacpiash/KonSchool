using System.ComponentModel.DataAnnotations.Schema;

namespace KonSchool.Models
{
    public partial class School
    {
#region Must-have
        private int eiin;
        public int EIIN { get => eiin; set => eiin = value; }

        private string name;
        public string Name { get => name; set => name = value; }
#endregion

        private double age;
        public double Age { get => age; set => age = value; }


#region Location
        [NotMapped]
        public Address Location => new Address(Division, District, Thana, Union_Ward);
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

        private string streetaddr;
        public string StreetAddr { get => streetaddr; set => streetaddr = value; }        

        private double distance;
        [NotMapped]
        public double Distance { get => distance; set => distance = value; }
#endregion
        
#region Eligibility
        private string type; // boys'/girls'/co-ed
        public string Type { get => type; set => type = value; }

        private string level; // ju-sec/sec/hi-sec
        public string Level { get => level; set => level = value; }
#endregion

#region AverAge
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
                    throw new System.Exception("Must have 5 values.");
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
        public double AverAge6 { get; set; }
        public double AverAge7 { get; set; }
        public double AverAge8 { get; set; }
        public double AverAge9 { get; set; }
        public double AverAgeX { get; set; }

        private double ads;
        // Actual age difference, stored when Query objct modifies the class instance.
        [NotMapped]
        public double ADS { get => ads; set => ads = value; }
#endregion

#region Ratio
        private double mfRatio;
        public double MFRatio { get => mfRatio; set => mfRatio = value; }

        private double tsRatio;
        public double TSRatio { get => tsRatio; set => tsRatio = value; }
#endregion
       
#region Socio-Economic Status (SES)
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
                    throw new System.Exception("Must have 4 values.");
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

        public double SEScore1 { get; set; }
        public double SEScore2 { get; set; }
        public double SEScore3 { get; set; }
        public double SEScore4 { get; set; }

        private double ses;
        // Stores Area-Score while reading from dataset. Will store actual SES after Query objct modifies the class instance.
        public double SES { get => ses; set => ses = value; }
#endregion

#region Finalization after FAHP
        private double[] _weightedScores;
        [NotMapped]
        public double[] WeightedScores { get => _weightedScores; set => _weightedScores = value; }
        
        [NotMapped]
        public double FinalScore { get; internal set; }
#endregion

        // ctor
        public School(int EIIN) => eiin = EIIN;
    }
}