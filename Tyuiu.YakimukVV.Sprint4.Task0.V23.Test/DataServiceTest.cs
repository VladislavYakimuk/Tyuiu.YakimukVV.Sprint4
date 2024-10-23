using Tyuiu.YakimukVV.Sprint4.Task0.V23.Lib;


namespace Tyuiu.YakimukVV.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            int expectedProduct = 9 * 3 * 7 * 1 * 5 * 5 * 3 * 1 * 7;

            DataService dataService = new DataService();

            int result = dataService.GetMultOddArrEl(array);

            Assert.AreEqual(expectedProduct, result);
        }

        [TestMethod]
        public void TestMethod_EmptyArray()
        {
            int[] array = { };

            int expectedProduct = 0;

            DataService dataService = new DataService();

            int result = dataService.GetMultOddArrEl(array);

            Assert.AreEqual(expectedProduct, result);
        }

        [TestMethod]
        public void TestMethod_NoOddNumbers()
        {
            int[] array = { 2, 4, 6, 8 };

            int expectedProduct = 0;

            DataService dataService = new DataService();

            int result = dataService.GetMultOddArrEl(array);

            Assert.AreEqual(expectedProduct, result);
        }
    }
}
