
namespace Tyuiu.SabarovDA.Sprint6.Task2.V16
{
    partial class FormMain_SDA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SDA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBoxData_SDA = new System.Windows.Forms.GroupBox();
            this.labelStop_SDA = new System.Windows.Forms.Label();
            this.labelStart_SDA = new System.Windows.Forms.Label();
            this.textBoxStop_SDA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxRes_SDA = new System.Windows.Forms.GroupBox();
            this.labelRes_SDA = new System.Windows.Forms.Label();
            this.dataGridViewFunction_SDA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxTask_SDA.SuspendLayout();
            this.groupBoxData_SDA.SuspendLayout();
            this.groupBoxRes_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBox3);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(453, 355);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1, 20);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(446, 329);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // groupBoxData_SDA
            // 
            this.groupBoxData_SDA.Controls.Add(this.labelStop_SDA);
            this.groupBoxData_SDA.Controls.Add(this.labelStart_SDA);
            this.groupBoxData_SDA.Controls.Add(this.textBoxStop_SDA);
            this.groupBoxData_SDA.Controls.Add(this.textBoxStart_SDA);
            this.groupBoxData_SDA.Location = new System.Drawing.Point(12, 373);
            this.groupBoxData_SDA.Name = "groupBoxData_SDA";
            this.groupBoxData_SDA.Size = new System.Drawing.Size(236, 65);
            this.groupBoxData_SDA.TabIndex = 1;
            this.groupBoxData_SDA.TabStop = false;
            this.groupBoxData_SDA.Text = "Ввод данных";
            // 
            // labelStop_SDA
            // 
            this.labelStop_SDA.AutoSize = true;
            this.labelStop_SDA.Location = new System.Drawing.Point(129, 19);
            this.labelStop_SDA.Name = "labelStop_SDA";
            this.labelStop_SDA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SDA.TabIndex = 3;
            this.labelStop_SDA.Text = "Конец шага:";
            // 
            // labelStart_SDA
            // 
            this.labelStart_SDA.AutoSize = true;
            this.labelStart_SDA.Location = new System.Drawing.Point(7, 20);
            this.labelStart_SDA.Name = "labelStart_SDA";
            this.labelStart_SDA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SDA.TabIndex = 2;
            this.labelStart_SDA.Text = "Старт шага:";
            // 
            // textBoxStop_SDA
            // 
            this.textBoxStop_SDA.Location = new System.Drawing.Point(129, 39);
            this.textBoxStop_SDA.Name = "textBoxStop_SDA";
            this.textBoxStop_SDA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SDA.TabIndex = 1;
            // 
            // textBoxStart_SDA
            // 
            this.textBoxStart_SDA.Location = new System.Drawing.Point(6, 39);
            this.textBoxStart_SDA.Name = "textBoxStart_SDA";
            this.textBoxStart_SDA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SDA.TabIndex = 0;
            // 
            // groupBoxRes_SDA
            // 
            this.groupBoxRes_SDA.Controls.Add(this.labelRes_SDA);
            this.groupBoxRes_SDA.Controls.Add(this.dataGridViewFunction_SDA);
            this.groupBoxRes_SDA.Controls.Add(this.chartFunction_SDA);
            this.groupBoxRes_SDA.Location = new System.Drawing.Point(471, 10);
            this.groupBoxRes_SDA.Name = "groupBoxRes_SDA";
            this.groupBoxRes_SDA.Size = new System.Drawing.Size(662, 428);
            this.groupBoxRes_SDA.TabIndex = 1;
            this.groupBoxRes_SDA.TabStop = false;
            this.groupBoxRes_SDA.Text = "Вывод данных";
            // 
            // labelRes_SDA
            // 
            this.labelRes_SDA.AutoSize = true;
            this.labelRes_SDA.Location = new System.Drawing.Point(6, 25);
            this.labelRes_SDA.Name = "labelRes_SDA";
            this.labelRes_SDA.Size = new System.Drawing.Size(62, 13);
            this.labelRes_SDA.TabIndex = 2;
            this.labelRes_SDA.Text = "Результат:";
            // 
            // dataGridViewFunction_SDA
            // 
            this.dataGridViewFunction_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column1});
            this.dataGridViewFunction_SDA.Location = new System.Drawing.Point(6, 50);
            this.dataGridViewFunction_SDA.Name = "dataGridViewFunction_SDA";
            this.dataGridViewFunction_SDA.RowHeadersVisible = false;
            this.dataGridViewFunction_SDA.Size = new System.Drawing.Size(225, 372);
            this.dataGridViewFunction_SDA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "F(X)";
            this.Column1.Name = "Column1";
            // 
            // chartFunction_SDA
            // 
            this.chartFunction_SDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SDA.Legends.Add(legend1);
            this.chartFunction_SDA.Location = new System.Drawing.Point(237, 19);
            this.chartFunction_SDA.Name = "chartFunction_SDA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SDA.Series.Add(series1);
            this.chartFunction_SDA.Size = new System.Drawing.Size(419, 403);
            this.chartFunction_SDA.TabIndex = 0;
            this.chartFunction_SDA.Text = "chart1";
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_SDA.Location = new System.Drawing.Point(254, 373);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(75, 65);
            this.buttonHelp_SDA.TabIndex = 2;
            this.buttonHelp_SDA.Text = " Справка";
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(335, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain_SDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonHelp_SDA);
            this.Controls.Add(this.groupBoxData_SDA);
            this.Controls.Add(this.groupBoxRes_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SDA";
            this.Text = "Спринт 6 | Таск 2 | Вариант 16 | Сабаров Д. А.   ";
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.groupBoxData_SDA.ResumeLayout(false);
            this.groupBoxData_SDA.PerformLayout();
            this.groupBoxRes_SDA.ResumeLayout(false);
            this.groupBoxRes_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBoxData_SDA;
        private System.Windows.Forms.TextBox textBoxStop_SDA;
        private System.Windows.Forms.TextBox textBoxStart_SDA;
        private System.Windows.Forms.GroupBox groupBoxRes_SDA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SDA;
        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label labelStop_SDA;
        private System.Windows.Forms.Label labelStart_SDA;
        private System.Windows.Forms.Label labelRes_SDA;
    }
}

