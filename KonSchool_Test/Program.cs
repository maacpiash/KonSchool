using System;
using System.IO;
using KonSchool_Models;

using static System.Console;
using static System.IO.File;

namespace KonSchool_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVreader myreader = new CSVreader(ReadAllLines("Dataset_ready.csv"));
            TestCSVreading(myreader);
        }

        static void TestCSVreading(CSVreader myreader)
        {
            string[] criteria;
            try
            {
                criteria = myreader.Attributes;
            }
            catch
            {
                WriteLine("Fired 1");
                return;
            }
            try
            {
                int max = criteria.Length;
                for(int i = 0; i < max; i++)
                    WriteLine(criteria[i]);
                    // supposed to write the list of criteria
            }
            catch
            {
                WriteLine("Fired 2");
                return;
            }
            
            
        }
    }
}
