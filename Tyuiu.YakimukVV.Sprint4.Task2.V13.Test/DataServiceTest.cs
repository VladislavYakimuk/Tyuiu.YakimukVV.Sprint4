using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint4.Task2.V13.Lib;

namespace Tyuiu.YakimukVV.Sprint4.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] testArray = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6 };

            int result = dataService.Calculate(testArray);

            Assert.AreEqual(2 * 4 * 6 * 8 * 2 * 4 * 6, result);
        }
    }
}
