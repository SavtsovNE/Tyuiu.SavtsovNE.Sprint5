using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavtsovNE.Sprint5.Task5.V24.Lib;
using System.IO;
namespace Tyuiu.SavtsovNE.Sprint5.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSptint5\InPutDataFileTask5V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}