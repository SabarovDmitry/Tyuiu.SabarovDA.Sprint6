using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint6.Task5.V30.Lib;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint6.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\UserHome\source\repos\Tyuiu.SabarovDA.Sprint6\Tyuiu.SabarovDA.Sprint6.Task5.V30\bin\Debug\InPutFileTask5V30.txt";
            double[] res = ds.LoadFromDataFile(path);
            double i = res[0];
            double wait = 5;
            Assert.AreEqual(wait, i);
        }
    }
}
