using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SabarovDA.Sprint6.Task2.V16.Lib;
namespace Tyuiu.SabarovDA.Sprint6.Task2.V16
{
    public partial class FormMain_SDA : Form
    {
        public FormMain_SDA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SDA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SDA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_SDA.Titles.Add("График функции F(x) = Cos(x) / x - 0,4 + Sin(x) * 8x + 2");
                this.chartFunction_SDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SDA.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SDA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_SDA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Сабаров Дмитрий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
