namespace KonSchool.Models
{
    public struct Address
    {
        public string Union_Ward;
        public string Thana;
        public string District;
        public string Division;

        public Address(string Division, string District, string Thana, string Union_Ward)
        {
            this.Division = Division;
            this.District = District;
            this.Thana = Thana;
            this.Union_Ward = Union_Ward;
        }
    }
}