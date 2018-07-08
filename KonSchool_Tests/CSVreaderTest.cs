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
            CSVreader fileReader = new CSVreader(filePath);
            Assert.Equal(fileReader.Height, 14274);
        }
    }
}
