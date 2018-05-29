using System;
using System.Globalization;
using Microsoft.AspNetCore.JsonPatch.Helpers;
using static System.Array;

namespace KonSchool_Models
{
    public class CSVreader
    {
        // EIIN

        // SIX_AVG
        // SEVEN_AVG
        // EIGHT_AVG
        // NINE_AVG
        // TEN_AVG

        // SEX_RATIO
        
        // LAWR, DOCT, ENGR, BUSI
        // GOVT, PRVT, TCHR
        // OTHR
        // EXPT, CULT, SBUS
        // WORK, FISH, TATI, KMKR
        
        
        // SIX_B	SIX_G
        // SEVEN_B	SEVEN_G
        // EIGHT_B	EIGHT_G
        // NINE_B	NINE_G
        // TEN_B	TEN_G

        // NAME
        // INSTITUTE_TYPE

        // DIVISION DISTRICT THANA UNION MAUZA AREA_STATUS GEOGRPYCAL_STATUS ADDRESS POST MOBILE
        // MANAGEMENT_TYPE STUDENT_TYPE LAVER_OF_EDUCATION EDUCATION_LEVEL
        // AFFILIATION	MPO_STATUS	SCHOOL_AGE	JUNIOR_MPO_AGE	SECONDARY_MPO_AGE

        private string[][] dataLines;
        private string[] attributes;
        private int[] eiins;
        private int keyIndex;
        private int height, width;

        public (int, int) Dimenstion => (height, width);

        public string[] Attributes => attributes;
        
        public string this[int EIIN, string Attribute] => dataLines[IndexOf(eiins, EIIN)][IndexOf(attributes, Attribute)];

        public CSVreader(string[] Lines)
        {
            try
            {
                height = Lines.Length - 1;
                attributes = Lines[0].Split(',');
                width = attributes.Length;
                Console.WriteLine($"Number of attributes: {width}");
                keyIndex = IndexOf(attributes, "EIIN");
                eiins = new int[height];
                dataLines = new string[height][];
                
                for (int i = 1; i <= height; i++)
                {
                    dataLines[i - 1] = Lines[i].Split(',');
                    eiins[i - 1] = Convert.ToInt32(dataLines[i - 1][keyIndex]);
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }
            
        }

    }    
}