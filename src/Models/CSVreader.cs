using System;

using static System.Array;

namespace KonSchool.Models
{
    public class CSVreader
    {
        #region private variables
        private string[][] dataLines;
        #endregion

        #region Public Properties
        public int Height { get; }
        public int Width { get; }

        public string[] Attributes { get; }
        public int[] EIINs { get; }

        public string this[int EIIN, string Attribute] => Indexer(EIIN, Attribute);

        #endregion

        private string Indexer(int EIIN, string Attribute)
        {
            try
            {
                return dataLines[IndexOf(EIINs, EIIN)][IndexOf(Attributes, Attribute)];
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:\nEIIN = {EIIN}\nAttribute = {Attribute}");
                Console.WriteLine(e);
                return "ERROR";
            }
        }

        public CSVreader(string filePath)
        {
            string[] Lines = System.IO.File.ReadAllLines(filePath);
            int i = 0;
            try
            {
                Height = Lines.Length - 1;
                Attributes = Lines[0].Split(',');
                Width = Attributes.Length;
                EIINs = new int[Height];
                dataLines = new string[Height][];
                string[] temp;
                for (i = 1; i <= Height; i++)
                {
                    temp = Lines[i].Split(',');
                    EIINs[i - 1] = Convert.ToInt32(temp[0]);
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

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < l; j++)
                    Console.Write(dataLines[i][IndexOf(Attributes, attrs[j])] + "\t");
                Console.WriteLine();
            }
        }

    }
}