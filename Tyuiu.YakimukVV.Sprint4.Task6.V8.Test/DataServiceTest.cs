using Tyuiu.YakimukVV.Sprint4.Task6.V8.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tyuiu.YakimukVV.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string[] data = { "�����", "����", "��������", "�����", "�����", "���", "�����" };

            string[] expected = { "�����", "��������", "�����", "�����", "�����" };

            string[] result = dataService.Calculate(data);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
