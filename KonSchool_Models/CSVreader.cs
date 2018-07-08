using System;

using static System.Array;

namespace KonSchool_Models
{
    public class CSVreader
    {
        #region private backing variables
        private string[][] dataLines;
        private string[] attributes;
        private int[] eiins;
        private int height, width;
        #endregion

        #region Public Properties
        public int Height => height;
        public int Width => width;

        public string[] Attributes => attributes;
        public int[] EIINs => eiins;

        public string this[int EIIN, string Attribute] => Indexer(EIIN, Attribute);
            
        #endregion

        private string Indexer(int EIIN, string Attribute)
        {
            try
            {
                return dataLines[IndexOf(eiins, EIIN)][IndexOf(attributes, Attribute)];
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:\nEIIN = {EIIN}\nAttribute = {Attribute}");
                return "ERROR";
            }
        }

        public CSVreader(string filePath)
        {
            string[] Lines = System.IO.File.ReadAllLines(filePath);
            int i = 0;
            try
            {
                height = Lines.Length - 1;
                attributes = Lines[0].Split(',');
                width = attributes.Length;
                eiins = new int[height];
                dataLines = new string[height][];
                string[] temp;
                for (i = 1; i <= height; i++)
                {
                    temp = Lines[i].Split(',');
                    eiins[i - 1] = Convert.ToInt32(temp[0]);
                    dataLines[i - 1] = temp;
                }
            }
            catch (Exception x)
            {
                Console.WriteLine($"Error for line number {i}\n{x.ToString()}");
            }
            
        }

        public void PrintAll(params string[] attrs)
        {
            int l = attrs.Length;
            for (int i = 0; i < l; i++)
            {
                Console.Write(attrs[i] + "\t");
            }
            Console.WriteLine();
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < l; j++)
                    Console.Write(dataLines[i][IndexOf(attributes, attrs[j])] + "\t");
                Console.WriteLine();
            }
        }

    }    
}