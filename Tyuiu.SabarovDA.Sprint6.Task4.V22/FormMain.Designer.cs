
using System;

namespace Tyuiu.SabarovDA.Sprint6.Task4.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.chartFunction_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxPutData_SDA = new System.Windows.Forms.GroupBox();
            this.labelVarB_SDA = new System.Windows.Forms.Label();
            this.labelVarA_SDA = new System.Windows.Forms.Label();
            this.textBoxVarB_SDA = new System.Windows.Forms.TextBox();
            this.textBoxVarA_SDA = new System.Windows.Forms.TextBox();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.buttonSave_SDA = new System.Windows.Forms.Button();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.panelTask_SDA = new System.Windows.Forms.Panel();
            this.panelTextResult_SDA = new System.Windows.Forms.Panel();
            this.panelChart_SDA = new System.Windows.Forms.Panel();
            this.chartResult_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterRes_SDA = new System.Windows.Forms.Splitter();
            this.groupBoxTask_SDA.SuspendLayout();
            this.groupBoxOutPutData_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).BeginInit();
            this.groupBoxPutData_SDA.SuspendLayout();
            this.panelTask_SDA.SuspendLayout();
            this.panelTextResult_SDA.SuspendLayout();
            this.panelChart_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(417, 68);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTask_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(6, 12);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.Size = new System.Drawing.Size(405, 50);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.Text = "Написать программу, которая выводит таблицу значений функции: \r\nЕ (х) = sin(x) + " +
    "cos(2x) / 2 - 1,5х\r\n";
            // 
            // groupBoxOutPutData_SDA
            // 
            this.groupBoxOutPutData_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxOutPutData_SDA.Location = new System.Drawing.Point(3, 6);
            this.groupBoxOutPutData_SDA.Name = "groupBoxOutPutData_SDA";
            this.groupBoxOutPutData_SDA.Size = new System.Drawing.Size(244, 341);
            this.groupBoxOutPutData_SDA.TabIndex = 1;
            this.groupBoxOutPutData_SDA.TabStop = false;
            this.groupBoxOutPutData_SDA.Text = "Вывод";
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.Location = new System.Drawing.Point(0, 19);
            this.textBoxResult_SDA.Multiline = true;
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(240, 310);
            this.textBoxResult_SDA.TabIndex = 1;
            this.textBoxResult_SDA.TextChanged += new System.EventHandler(this.textBoxResult_SDA_TextChanged);
            // 
            // chartFunction_SDA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_SDA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_SDA.Legends.Add(legend3);
            this.chartFunction_SDA.Location = new System.Drawing.Point(114, 59);
            this.chartFunction_SDA.Name = "chartFunction_SDA";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_SDA.Series.Add(series3);
            this.chartFunction_SDA.Size = new System.Drawing.Size(249, 147);
            this.chartFunction_SDA.TabIndex = 0;
            this.chartFunction_SDA.Text = "chart1";
            // 
            // groupBoxPutData_SDA
            // 
            this.groupBoxPutData_SDA.Controls.Add(this.labelVarB_SDA);
            this.groupBoxPutData_SDA.Controls.Add(this.labelVarA_SDA);
            this.groupBoxPutData_SDA.Controls.Add(this.textBoxVarB_SDA);
            this.groupBoxPutData_SDA.Controls.Add(this.textBoxVarA_SDA);
            this.groupBoxPutData_SDA.Location = new System.Drawing.Point(445, 12);
            this.groupBoxPutData_SDA.Name = "groupBoxPutData_SDA";
            this.groupBoxPutData_SDA.Size = new System.Drawing.Size(193, 68);
            this.groupBoxPutData_SDA.TabIndex = 1;
            this.groupBoxPutData_SDA.TabStop = false;
            this.groupBoxPutData_SDA.Text = "Ввод данных";
            // 
            // labelVarB_SDA
            // 
            this.labelVarB_SDA.AutoSize = true;
            this.labelVarB_SDA.Location = new System.Drawing.Point(93, 16);
            this.labelVarB_SDA.Name = "labelVarB_SDA";
            this.labelVarB_SDA.Size = new System.Drawing.Size(69, 13);
            this.labelVarB_SDA.TabIndex = 4;
            this.labelVarB_SDA.Text = "Конец шага:";
            // 
            // labelVarA_SDA
            // 
            this.labelVarA_SDA.AutoSize = true;
            this.labelVarA_SDA.Location = new System.Drawing.Point(7, 13);
            this.labelVarA_SDA.Name = "labelVarA_SDA";
            this.labelVarA_SDA.Size = new System.Drawing.Size(67, 13);
            this.labelVarA_SDA.TabIndex = 3;
            this.labelVarA_SDA.Text = "Старт шага:";
            // 
            // textBoxVarB_SDA
            // 
            this.textBoxVarB_SDA.Location = new System.Drawing.Point(96, 31);
            this.textBoxVarB_SDA.Multiline = true;
            this.textBoxVarB_SDA.Name = "textBoxVarB_SDA";
            this.textBoxVarB_SDA.Size = new System.Drawing.Size(91, 31);
            this.textBoxVarB_SDA.TabIndex = 2;
            // 
            // textBoxVarA_SDA
            // 
            this.textBoxVarA_SDA.Location = new System.Drawing.Point(6, 31);
            this.textBoxVarA_SDA.Multiline = true;
            this.textBoxVarA_SDA.Name = "textBoxVarA_SDA";
            this.textBoxVarA_SDA.Size = new System.Drawing.Size(84, 31);
            this.textBoxVarA_SDA.TabIndex = 1;
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_SDA.Location = new System.Drawing.Point(644, 13);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(75, 61);
            this.buttonDone_SDA.TabIndex = 2;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // buttonSave_SDA
            // 
            this.buttonSave_SDA.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_SDA.Location = new System.Drawing.Point(725, 13);
            this.buttonSave_SDA.Name = "buttonSave_SDA";
            this.buttonSave_SDA.Size = new System.Drawing.Size(75, 61);
            this.buttonSave_SDA.TabIndex = 3;
            this.buttonSave_SDA.Text = "Сохранить";
            this.buttonSave_SDA.UseVisualStyleBackColor = false;
            this.buttonSave_SDA.Click += new System.EventHandler(this.buttonSave_SDA_Click);
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SDA.Location = new System.Drawing.Point(804, 12);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(75, 61);
            this.buttonHelp_SDA.TabIndex = 4;
            this.buttonHelp_SDA.Text = "Справка";
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // panelTask_SDA
            // 
            this.panelTask_SDA.Controls.Add(this.buttonHelp_SDA);
            this.panelTask_SDA.Controls.Add(this.groupBoxPutData_SDA);
            this.panelTask_SDA.Controls.Add(this.groupBoxTask_SDA);
            this.panelTask_SDA.Controls.Add(this.buttonSave_SDA);
            this.panelTask_SDA.Controls.Add(this.buttonDone_SDA);
            this.panelTask_SDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_SDA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_SDA.Name = "panelTask_SDA";
            this.panelTask_SDA.Size = new System.Drawing.Size(899, 100);
            this.panelTask_SDA.TabIndex = 2;
            this.panelTask_SDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelTextResult_SDA
            // 
            this.panelTextResult_SDA.Controls.Add(this.groupBoxOutPutData_SDA);
            this.panelTextResult_SDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTextResult_SDA.Location = new System.Drawing.Point(0, 100);
            this.panelTextResult_SDA.Name = "panelTextResult_SDA";
            this.panelTextResult_SDA.Size = new System.Drawing.Size(253, 350);
            this.panelTextResult_SDA.TabIndex = 3;
            this.panelTextResult_SDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTextResult_SDA_Paint);
            // 
            // panelChart_SDA
            // 
            this.panelChart_SDA.Controls.Add(this.splitterRes_SDA);
            this.panelChart_SDA.Controls.Add(this.chartResult_SDA);
            this.panelChart_SDA.Location = new System.Drawing.Point(249, 100);
            this.panelChart_SDA.Name = "panelChart_SDA";
            this.panelChart_SDA.Size = new System.Drawing.Size(650, 350);
            this.panelChart_SDA.TabIndex = 4;
            // 
            // chartResult_SDA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_SDA.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartResult_SDA.Legends.Add(legend4);
            this.chartResult_SDA.Location = new System.Drawing.Point(6, 9);
            this.chartResult_SDA.Name = "chartResult_SDA";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_SDA.Series.Add(series4);
            this.chartResult_SDA.Size = new System.Drawing.Size(637, 341);
            this.chartResult_SDA.TabIndex = 0;
            this.chartResult_SDA.Text = "График функции";
            // 
            // splitterRes_SDA
            // 
            this.splitterRes_SDA.Location = new System.Drawing.Point(0, 0);
            this.splitterRes_SDA.Name = "splitterRes_SDA";
            this.splitterRes_SDA.Size = new System.Drawing.Size(10, 350);
            this.splitterRes_SDA.TabIndex = 1;
            this.splitterRes_SDA.TabStop = false;
            // 
            // FormMain_SDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.panelChart_SDA);
            this.Controls.Add(this.panelTextResult_SDA);
            this.Controls.Add(this.panelTask_SDA);
            this.Name = "FormMain_SDA";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_SDA_Load);
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.groupBoxOutPutData_SDA.ResumeLayout(false);
            this.groupBoxOutPutData_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).EndInit();
            this.groupBoxPutData_SDA.ResumeLayout(false);
            this.groupBoxPutData_SDA.PerformLayout();
            this.panelTask_SDA.ResumeLayout(false);
            this.panelTextResult_SDA.ResumeLayout(false);
            this.panelChart_SDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SDA)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SDA;
        private System.Windows.Forms.GroupBox groupBoxPutData_SDA;
        private System.Windows.Forms.Label labelVarB_SDA;
        private System.Windows.Forms.Label labelVarA_SDA;
        private System.Windows.Forms.TextBox textBoxVarB_SDA;
        private System.Windows.Forms.TextBox textBoxVarA_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.Button buttonSave_SDA;
        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
        private System.Windows.Forms.Panel panelTask_SDA;
        private System.Windows.Forms.Panel panelTextResult_SDA;
        private System.Windows.Forms.Panel panelChart_SDA;
        protected internal System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SDA;
        private System.Windows.Forms.Splitter splitterRes_SDA;
    }
}

