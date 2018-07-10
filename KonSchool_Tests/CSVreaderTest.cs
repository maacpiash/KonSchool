using System;
using Xunit;
using KonSchool_Models;
using System.IO;

namespace KonSchool_Tests
{
    public class CSVreaderTest
    {
        [Fact]
        public void Test1()
        {
            string filePath;
            filePath = Environment.CurrentDirectory;
            for (int i = 0; i < 4; i++)
            {
                filePath = Directory.GetParent(filePath).FullName;
            }
            filePath = Path.Combine(filePath, "Dataset.csv");
            CSVreader fileReader = new CSVreader(filePath);
            Assert.Equal(fileReader.Height, 14274);
        }
    }
}
