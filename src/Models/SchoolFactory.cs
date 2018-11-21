using System;
using System.Collections.Generic;
using System.Text;

using static System.Math;
using static System.Convert;

namespace KonSchool.Models
{
    public sealed class SchoolFactory
    {
        private static readonly object key = new object();
        private CSVreader myReader;
        int numberOfSchools;
        private List<School> schools;
        public List<School> Schools
        {
            get
            {
                if (schools == null)
                {
                    lock (key)
                    {
                        if (schools == null)
                        {
                            numberOfSchools = myReader.Height;
                            schools = new List<School>();

                            int eiin;
                            School school;
                            for (int i = 1; i < numberOfSchools; i++)
                            {
                                eiin = myReader.EIINs[i];
                                school = new School(eiin)
                                {
                                    Name = myReader[eiin, "INSTITUTE NAME"],
                                    OLD = ToDouble(myReader[eiin, "AS_SCORE"]),

                                    Division = myReader[eiin, "DIVISION"],
                                    District = myReader[eiin, "DISTRICT"],
                                    Thana = myReader[eiin, "THANA"],
                                    Union_Ward = myReader[eiin, "UNION_NAME"],

                                    StreetAddr = myReader[eiin, "ADDRESS"],
                                    MobileNum = myReader[eiin, "MOBILE"],
                                    Type = myReader[eiin, "STUDENT_TYPE"],
                                    Level = myReader[eiin, "EDUCATION_LEVEL"],
                                    
                                    AverAge6 = ToDouble(myReader[eiin, "SIX_AVG"]),
                                    AverAge7 = ToDouble(myReader[eiin, "SEVEN_AVG"]),
                                    AverAge8 = ToDouble(myReader[eiin, "EIGHT_AVG"]),
                                    AverAge9 = ToDouble(myReader[eiin, "NINE_AVG"]),
                                    AverAgeX = ToDouble(myReader[eiin, "TEN_AVG"]),

                                    MFR = ToDouble(myReader[eiin, "FEM_STD_RATIO"]),
                                    TSR = ToDouble(myReader[eiin, "TSR_SCORE"]),

                                    SEScore1 = ToDouble(myReader[eiin, "SESscore_LO"]),
                                    SEScore2 = ToDouble(myReader[eiin, "SESscore_LM"]),
                                    SEScore3 = ToDouble(myReader[eiin, "SESscore_UM"]),
                                    SEScore4 = ToDouble(myReader[eiin, "SESscore_UP"]),
                                    SES = ToDouble(myReader[eiin, "AScore"]),

                                };
                            }
                        }
                    }
                }
                return schools;
            }
        }


        public SchoolFactory(string csvPath)
        {
            myReader = new CSVreader(csvPath);
        }
    }
}
