using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint6.Task6.V28.Lib
{
    public class DataService : ISprint6Task6V28
    {
        public string CollectTextFromFile(string str, string path)
        {
            str = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    if (words.Length >= 2)
                    {
                        str += words[words.Length - 2] + " ";
                    }
                }
            }
            return str;
        }
    }
}
