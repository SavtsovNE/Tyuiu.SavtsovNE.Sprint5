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
            string path = @"C:/app/data/ServiceWorkFolder/5a9c64812e714ffea5cc9516d016aa6e/Tyuiu.SavtsovNE/Tyuiu.SavtsovNE.Sprint5.Task2.V4.Lib/Tyuiu.SavtsovNE.Sprint5.Task2.V4.Lib.csproj";
            


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}