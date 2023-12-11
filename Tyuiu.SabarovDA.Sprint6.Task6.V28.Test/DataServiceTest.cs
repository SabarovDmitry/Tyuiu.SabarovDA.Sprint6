using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SabarovDA.Sprint6.Task6.V28.Lib;
namespace Tyuiu.SabarovDA.Sprint6.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DataService = new DataService();
        }
        [TestMethod]
        public void ExistsFile()
        {
            string path = @"C:\Users\UserHome\source\repos\Tyuiu.SabarovDA.Sprint6\Tyuiu.SabarovDA.Sprint6.Task6.V28\bin\Debug\InPutFileTask6V28.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckArray()
        {
            string path = @"C:\Users\UserHome\source\repos\Tyuiu.SabarovDA.Sprint6\Tyuiu.SabarovDA.Sprint6.Task6.V28\bin\Debug\InPutFileTask6V28.txt";
            string res = "wFrlYaZtHI l eAezSXF eqSGAiC wUdVEuNB ";
            string str = DataService.CollectTextFromFile(res, path);
            Assert.AreEqual(str, res);



        }
    }
}