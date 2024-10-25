using Tyuiu.YakimukVV.Sprint4.Task7.V28.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.YakimukVV.Sprint4.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int expected = 4608; 
            int result = dataService.Calculate(5, 3, "623351179845632");
            Assert.AreEqual(expected, result);
        }
    }
}
