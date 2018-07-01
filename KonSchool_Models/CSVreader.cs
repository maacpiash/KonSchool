using System;
using System.Globalization;
using Microsoft.AspNetCore.JsonPatch.Helpers;
using static System.Array;

namespace KonSchool_Models
{
    public class CSVreader
    {
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