namespace KonSchool_Models
{
    public partial class School
    {
        private int eiin;
        public int EIIN { get => eiin; set => eiin = (value > 100_000) ? value : 0; }

        private string name;
        public string Name { get => name; set => name = value; }
        
        private int age;
        public int Age { get => age; set => age = value; }

        private Address location;
        public Address Location { get => location; set => location = value; }

        private string type;
        public string Type { get => type; set => type = value; }

        private double[] avgAge;
        public double[] AverageAge { get => avgAge; set => avgAge = value; }

        private double[] smfRatio;
        public double[] Students_MFRatio { get => smfRatio; set => smfRatio = value; }

        private double[] tmfRatio;
        public double[] Teachers_MFRatio { get => tmfRatio; set => tmfRatio = value; }

        private int[,] _byGP;
        public int[,] Students_byGuardiansProfession { get => _byGP; set => _byGP = value; }

        private int[,] _BySex;
        public int[,] Teachers_bySex { get => _BySex; set => _BySex = value; }

        private bool cont;
        public bool Continuity { get => cont; set => cont = value; }

        public School(int EIIN) => eiin = EIIN;
    }

    public struct Address
    {
        public string Union;
        public string Thana;
        public string District;
        public string Division;
    }
}