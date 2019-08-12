using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NameSorter;
using System.IO;
namespace Name_Sorter_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Exception expectedExcetpion = null;
            try
            {
                string[] lines = File.ReadAllLines(@"unsorted-names-list.txt");
                NameSorter.NameSorter.SortByLastName(lines);
            }

            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }
            Assert.IsNotNull(expectedExcetpion);
        }
    }
}
