using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SabarovDA.Sprint6.Task0.V29.Lib;
namespace Tyuiu.SabarovDA.Sprint6.Task0.V29
{
    public partial class FormMain_SDA : Form
    {
        public FormMain_SDA()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonResult_SDA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try

            {
                textBoxResult_SDA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxB_SDA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxA_SDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
                {
                e.Handled = true;
             }  
        }

        private void textBoxResult_SDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWhoMade_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИППб-23-1 Сабаров Дмитрий Александрович", "Сообщение");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxB_SDA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
