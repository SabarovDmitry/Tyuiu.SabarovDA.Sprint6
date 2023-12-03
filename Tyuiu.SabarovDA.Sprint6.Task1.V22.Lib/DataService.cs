using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SabarovDA.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double y;
            int len = (stopValue - startValue) + 1;
            double[] func = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((3 * x + 2 - (((2 * x) - x) / (Math.Cos(x) + 1))), 2);
                func[count] = y;
                count++;
            }
            return func;
        }
    }
}
