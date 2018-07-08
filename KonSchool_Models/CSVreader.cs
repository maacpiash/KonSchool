using System;
using System.Globalization;
using Microsoft.AspNetCore.JsonPatch.Helpers;

using static System.Array;

namespace KonSchool_Models
{
    public class CSVreader
    {
        public const int MAX = 36868;
        public const int OFFSET = 100_000;

        #region private backing variables
        private string[][] dataLines;
        private string[] attributes;
        private int[] eiins;
        private int keyIndex;
        private int height, width;
        #endregion

        #region Public Properties
        public int Height => height;
        public int Width => width;

        public string[] Attributes => attributes;
        public int[] EIINs => eiins;
        
        public string this[int EIIN, string Attribute] => dataLines[EIIN - OFFSET][IndexOf(attributes, Attribute)];
        #endregion

        public CSVreader(string[] Lines)
        {
            int i = 0;
            try
            {
                height = Lines.Length - 1;
                attributes = Lines[0].Split(',');
                width = attributes.Length;
                //Console.WriteLine($"Number of attributes: {width}");
                keyIndex = IndexOf(attributes, "EIIN");
                eiins = new int[MAX];
                dataLines = new string[MAX][];
                string[] temp;
                for (i = 1; i <= MAX; i++)
                {
                    temp = Lines[i].Split(',');
                    eiins[i - 1] = Convert.ToInt32(temp[0]) - OFFSET;
                    dataLines[eiins[i - 1]] = temp;
                }
            }
            catch (Exception x)
            {
                Console.WriteLine($"Error for line number {i}\n{x.ToString()}");
            }
            
        }

    }    
}