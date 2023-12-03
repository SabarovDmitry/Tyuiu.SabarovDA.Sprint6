using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SabarovDA.Sprint6.Task1.V22.Lib;
namespace Tyuiu.SabarovDA.Sprint6.Task1.V22
{
    public partial class FormMain_SDA : Form
    {
        public FormMain_SDA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxFirstStep_SDA.Text);
                int stopstep = Convert.ToInt32(textBoxEndStep_SDA.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_SDA.Text = "";
                textBoxResult_SDA.AppendText("+------------------------+" + Environment.NewLine);
                textBoxResult_SDA.AppendText("|    x     |     f(x)    |" + Environment.NewLine);
                textBoxResult_SDA.AppendText("+------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 7:f2}    |", startstep, func[i]);
                    textBoxResult_SDA.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_SDA.AppendText("+------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Сабаров Д. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
