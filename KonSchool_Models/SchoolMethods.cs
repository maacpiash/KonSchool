using System;
using System.Linq;
using static System.Convert;

namespace KonSchool_Models
{
    public partial class School
    {
        public bool IsEligible(Query q)
            => !((q.IsMale && type == "GIRLS") || (q.Class > 8 && level == "Junior Secondary"));

        public double[] ScoreValues(Query q)
        {
            int max = q.Criteria.Length;
            string temp;
            double[] scores = new double[max];

            for (int i = 0; i < max; i++)
            {
                temp = q.Criteria[i];
                switch (temp)
                {
                    case "TSR": scores[i] = tsRatio; break;
                    case "SES": scores[i] = seScore; break;
                    case "MFR": scores[i] = smfRatio; break;
                    case "AS": scores[i] = age; break;
                    case "DIST": scores[i] = distance; break;
                    case "ADS": scores[i] = averAge; break;
                    default: scores[i] = 0.0; break;
                }
            }
            return scores;
        }

        
    }
}