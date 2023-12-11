using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SabarovDA.Sprint6.Task6.V28.Lib;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath = @"C:\Users\UserHome\source\repos\Tyuiu.SabarovDA.Sprint6\Tyuiu.SabarovDA.Sprint6.Task6.V28\bin\Debug\InPutFileTask6V28.txt";
        DataService DataService = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogRes_SDA.ShowDialog();
            openFilePath = openFileDialogRes_SDA.FileName;
            textBoxFileInput_SDA.Text = File.ReadAllText(openFilePath);
            groupBoxRes_SDA.Text = groupBoxRes_SDA.Text + " " + openFileDialogRes_SDA.FileName;
            buttonFile_SDA.Enabled = true;  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = " ";
            openFileDialogRes_SDA.Text = DataService.CollectTextFromFile(str, openFilePath);
        }
    }
}
