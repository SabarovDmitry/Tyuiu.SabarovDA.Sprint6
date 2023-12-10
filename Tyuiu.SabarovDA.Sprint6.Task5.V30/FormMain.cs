using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SabarovDA.Sprint6.Task5.V30.Lib;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint6.Task5.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\UserHome\source\repos\Tyuiu.SabarovDA.Sprint6\Tyuiu.SabarovDA.Sprint6.Task5.V30\bin\Debug\InPutFileTask5V30.txt";
        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_SDA.ColumnCount = 2;
            dataGridViewRes_SDA.Columns[0].Width = 20;
            dataGridViewRes_SDA.Columns[1].Width = 50;
            this.chartRes_SDA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartRes_SDA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartRes_SDA.Series[0].Points.Clear();
            double[] mas = new double[ds.len];
            mas = ds.LoadFromDataFile(path);
            for (int i = 0; i < mas.Length; i++)
            {
                dataGridViewRes_SDA.Rows.Add(Convert.ToString(i), Convert.ToString(mas[i]));
                chartRes_SDA.Series[0].Points.AddXY(i, mas[i]);
            }
        }

        private void buttonOpen_SDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-1 Сабаров Дмитрий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

