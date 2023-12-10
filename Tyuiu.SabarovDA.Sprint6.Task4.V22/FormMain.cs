using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SabarovDA.Sprint6.Task4.V22.Lib;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint6.Task4.V22
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
                int startStep = Convert.ToInt32(textBoxVarA_SDA.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_SDA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_SDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_SDA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SDA.Text = "";

                chartResult_SDA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_SDA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_SDA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-1 Сабаров Дмитрий Александрович ", "Сообщение");
        }

        private void buttonSave_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V22.txt";
                File.WriteAllText(path, textBoxResult_SDA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void textBoxResult_SDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_SDA_Load(object sender, EventArgs e)
        {

        }

        private void panelTextResult_SDA_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
