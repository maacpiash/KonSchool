namespace KonSchool_Models
{
    public partial class School
    {
        private bool ethn;
        public bool EthnicStudents { get => ethn; set => ethn = value; }

        private bool bus;
        public bool HasBusiness { get => bus; set => bus = value; }

        private bool voc;
        public bool HasVocational { get => voc; set => voc = value; }
        
    }
}