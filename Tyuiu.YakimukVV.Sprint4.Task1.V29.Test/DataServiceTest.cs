using Tyuiu.YakimukVV.Sprint4.Task1.V29.Lib;
namespace Tyuiu.YakimukVV.Sprint4.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] testArray = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };
            int expectedSum = 31; 

            int actualSum = dataService.Calculate(testArray);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
