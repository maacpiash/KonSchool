using System;
using System.Globalization;
using Microsoft.AspNetCore.JsonPatch.Helpers;

namespace KonSchool_Models
{
    public class CSVreader
    {
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
        
        public string this[int EIIN, string Attribute] => dataLines[Array.IndexOf(eiins, EIIN)][Array.IndexOf(attributes, Attribute)];
        #endregion

        public CSVreader(string[] Lines)
        {
            int i = 0;
            try
            {
                height = Lines.Length - 1;
                attributes = Lines[0].Split(',');
                width = attributes.Length;
                Console.WriteLine($"Number of attributes: {width}");
                keyIndex = Array.IndexOf(attributes, "EIIN");
                eiins = new int[height];
                dataLines = new string[height][];
                
                for (i = 1; i <= height; i++)
                {
                    dataLines[i - 1] = Lines[i].Split(',');
                    eiins[i - 1] = Convert.ToInt32(dataLines[i - 1][keyIndex]);
                }
            }
            catch (Exception x)
            {
                Console.WriteLine($"Error for line number {i}\n{x.ToString()}");
            }
            
        }

    }    
}