using System;
using Xunit;
using KonSchool_Models;

namespace KonSchool_Tests
{
    public class CSVreaderTest
    {
        [Fact]
        public void Test1()
        {
            string filePath = "/Users/piash/Code/KonSchool/Dataset.csv";
            CSVreader fileReader = new CSVreader(System.IO.File.ReadAllLines(filePath));
            Assert.Equal(fileReader.Height, 14274);
        }
    }
}
