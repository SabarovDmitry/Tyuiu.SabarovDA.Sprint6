using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SabarovDA.Sprint6.Task0.V29.Lib
{
    public class DataService : ISprint6Task0V29
    {
        public double Calculate(int x)
        {
            {
                double res = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
                return Math.Round(res, 3);
            }
        }
    }
}
