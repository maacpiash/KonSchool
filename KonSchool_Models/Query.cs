using System.Collections.Generic;

namespace KonSchool_Models
{
    public class Query
    {
        private int _class;
        private int _social;
        private bool _isMale;
        private int _age;
        private string _occupation;
        private Address _location;

        public int Class
        {
            get => _class;
            set => _class = value;
        }

        public int Social
        {
            get => _social;
            set => _social = value;
        }

        public bool IsMale
        {
            get => _isMale;
            set => _isMale = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Occupation
        {
            get => _occupation;
            set => _occupation = GetOccupations().Contains(value) ? value : "Other";
        }

        public Address Location
        {
            get => _location;
            set => _location = value;
        }

        private static List<string> Occupations;

        public static List<string> GetOccupations()
        {
            if (Occupations == null)
                Occupations = new List<string>()
                {
                    "Worker", "Fisherman", "Tati", "Kamar/Kumar",
                    "Cultivation", "Expatriate", "Small business",
                    "Govt. job", "Private job", "Teacher",
                    "Lawyer", "Doctor", "Engineer", "Businessman"
                };
            return Occupations;

        }
        
    }
}
 