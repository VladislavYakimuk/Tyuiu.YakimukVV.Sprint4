using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint4.Task5.V30.Lib;

namespace Tyuiu.YakimukVV.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            int[,] matrix = new int[,]
            {
                { -2, 1, 3, -1, 0 },
                { 2, -2, 4, -1, -1 },
                { -2, -2, -2, -2, -2 },
                { 1, 1, 1, 1, 1 },
                { 4, 4, 4, 4, 4 }
            };

            int result = dataService.Calculate(matrix);

            Assert.AreEqual(35, result, "Сумма положительных элементов не совпадает с ожидаемой.");
        }
    }
}
