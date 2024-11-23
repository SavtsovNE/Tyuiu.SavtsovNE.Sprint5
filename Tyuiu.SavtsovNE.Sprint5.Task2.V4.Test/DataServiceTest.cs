using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using Tyuiu.SavtsovNE.Sprint5.Task2.V4.Lib;

namespace Tyuiu.SavtsovNE.Sprint5.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.SavtsovNE.Sprint5\Tyuiu.SavtsovNE.Sprint5.Task2.V4\bin\Debug\OutPutFileTask2.csv";
                           
        FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}