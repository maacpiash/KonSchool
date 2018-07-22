using System.Collections.Generic;

using static KonSchool_Models.SerialNumbers;

namespace KonSchool_Models
{
    public class BootStrap
    {
        public double[] FinalScores;

        public BootStrap(Query query, FAHP fAHP)
        {
            School[] schools = query.Schools;
            double[] weights = fAHP.CriteriaWeights;
            int[] alts = query.Alternatives;
            int max = alts.Length;
            FinalScores = new double[max];
            for (int i = 0; i < max; i++)
                FinalScores[i] = weights[TSR] * schools[alts[i]].TeacherStudentRatio
                               + weights[SES] * schools[alts[i]].SEScore
                               + weights[MFR] * schools[alts[i]].Students_MFRatio
                               + weights[AS] * schools[alts[i]].Age
                               + weights[DIST] * schools[alts[i]].Distance
                               + weights[ADS] * schools[alts[i]].AverAge;
        }
    }
}
