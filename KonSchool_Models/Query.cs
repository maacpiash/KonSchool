namespace KonSchool_Models
{
    public class Query
    {
        private int _class;
        private int _occupation;
        private bool _isMale;
        private int _age;
        private Address _location;

        public int Class
        {
            get => _class;
            set => _class = value;
        }

        public int Occupation
        {
            get => _occupation;
            set => _occupation = value;
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

        public Address Location
        {
            get => _location;
            set => _location = value;
        }
    }
}