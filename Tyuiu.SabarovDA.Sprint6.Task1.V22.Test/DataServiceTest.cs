using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint6.Task1.V22.Lib;
namespace Tyuiu.SabarovDA.Sprint6.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;
            double[] wait = new double[len];
            wait[0] = -9.10;
            wait[1] = 1.55;
            wait[2] = 292.78;
            wait[3] = -0.57;
            wait[4] = -0.35;
            wait[5] = 2.00;
            wait[6] = 4.35;
            wait[7] = 4.57;
            wait[8] = -288.78;
            wait[9] = 2.45;
            wait[10] = 13.10;
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
