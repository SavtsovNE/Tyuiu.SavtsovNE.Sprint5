using System.IO;
using Tyuiu.SavtsovNE.Sprint5.Task1.V11.Lib;
namespace Tyuiu.SavtsovNE.Sprint5.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculateValid()
        {
            DataService ds = new();
            int x = 0;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}