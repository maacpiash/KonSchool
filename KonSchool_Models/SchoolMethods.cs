namespace KonSchool_Models
{
    public partial class School
    {
        public bool IsEligible(Query q)
        {
            if (q.IsMale && type == "GIRLS")
                return false;
            if (q.Class > 8 && level.Contains("Junior Secondary"))
                return false;
            return true;
        }

        public double ScoreMFR()
        {
            return 0.0;
        }
    }
}

