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
            CSVreader myreader = new CSVreader(ReadAllLines("dataset.csv"));
            string[] criteria = myreader.Attributes;
            for(int i = 0; i < 5; i++)
                WriteLine(criteria[i]);
                // supposed to write the list of criteria
            WriteLine(myreader[102, "SCHOOL NAME"]);
            // supposed to write "IDEAL SCHOOL AND COLLEGE"
        }
    }
}
