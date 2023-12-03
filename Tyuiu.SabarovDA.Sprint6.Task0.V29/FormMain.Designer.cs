
namespace Tyuiu.SabarovDA.Sprint6.Task0.V29
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
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_SDA = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_SDA = new System.Windows.Forms.GroupBox();
            this.labelB_SDA = new System.Windows.Forms.Label();
            this.textBoxB_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SDA = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.buttonResult_SDA = new System.Windows.Forms.Button();
            this.buttonWhoMade_SDA = new System.Windows.Forms.Button();
            this.groupBoxTask_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).BeginInit();
            this.groupBoxInput_SDA.SuspendLayout();
            this.groupBoxResult_SDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.pictureBoxFormula_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(790, 228);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(572, 97);
            this.textBoxTask_SDA.TabIndex = 1;
            this.textBoxTask_SDA.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой. ";
            // 
            // pictureBoxFormula_SDA
            // 
            this.pictureBoxFormula_SDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SDA.Image")));
            this.pictureBoxFormula_SDA.Location = new System.Drawing.Point(650, 19);
            this.pictureBoxFormula_SDA.Name = "pictureBoxFormula_SDA";
            this.pictureBoxFormula_SDA.Size = new System.Drawing.Size(126, 97);
            this.pictureBoxFormula_SDA.TabIndex = 0;
            this.pictureBoxFormula_SDA.TabStop = false;
            this.pictureBoxFormula_SDA.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBoxInput_SDA
            // 
            this.groupBoxInput_SDA.Controls.Add(this.labelB_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxB_SDA);
            this.groupBoxInput_SDA.Location = new System.Drawing.Point(12, 246);
            this.groupBoxInput_SDA.Name = "groupBoxInput_SDA";
            this.groupBoxInput_SDA.Size = new System.Drawing.Size(504, 123);
            this.groupBoxInput_SDA.TabIndex = 1;
            this.groupBoxInput_SDA.TabStop = false;
            this.groupBoxInput_SDA.Text = "Ввода данных";
            // 
            // labelB_SDA
            // 
            this.labelB_SDA.AutoSize = true;
            this.labelB_SDA.Location = new System.Drawing.Point(184, 33);
            this.labelB_SDA.Name = "labelB_SDA";
            this.labelB_SDA.Size = new System.Drawing.Size(84, 13);
            this.labelB_SDA.TabIndex = 4;
            this.labelB_SDA.Text = "Переменная X:";
            // 
            // textBoxB_SDA
            // 
            this.textBoxB_SDA.Location = new System.Drawing.Point(187, 49);
            this.textBoxB_SDA.Name = "textBoxB_SDA";
            this.textBoxB_SDA.Size = new System.Drawing.Size(131, 20);
            this.textBoxB_SDA.TabIndex = 1;
            this.textBoxB_SDA.TextChanged += new System.EventHandler(this.textBoxB_SDA_TextChanged);
            this.textBoxB_SDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_SDA_KeyPress);
            // 
            // groupBoxResult_SDA
            // 
            this.groupBoxResult_SDA.Controls.Add(this.labelResult);
            this.groupBoxResult_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxResult_SDA.Location = new System.Drawing.Point(522, 246);
            this.groupBoxResult_SDA.Name = "groupBoxResult_SDA";
            this.groupBoxResult_SDA.Size = new System.Drawing.Size(266, 123);
            this.groupBoxResult_SDA.TabIndex = 2;
            this.groupBoxResult_SDA.TabStop = false;
            this.groupBoxResult_SDA.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 49);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            this.labelResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.Location = new System.Drawing.Point(6, 65);
            this.textBoxResult_SDA.Multiline = true;
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ReadOnly = true;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(254, 43);
            this.textBoxResult_SDA.TabIndex = 0;
            this.textBoxResult_SDA.TextChanged += new System.EventHandler(this.textBoxResult_SDA_TextChanged);
            // 
            // buttonResult_SDA
            // 
            this.buttonResult_SDA.Location = new System.Drawing.Point(654, 403);
            this.buttonResult_SDA.Name = "buttonResult_SDA";
            this.buttonResult_SDA.Size = new System.Drawing.Size(134, 35);
            this.buttonResult_SDA.TabIndex = 3;
            this.buttonResult_SDA.Text = "Выполнить";
            this.buttonResult_SDA.UseVisualStyleBackColor = true;
            this.buttonResult_SDA.Click += new System.EventHandler(this.buttonResult_SDA_Click);
            // 
            // buttonWhoMade_SDA
            // 
            this.buttonWhoMade_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhoMade_SDA.Location = new System.Drawing.Point(607, 403);
            this.buttonWhoMade_SDA.Name = "buttonWhoMade_SDA";
            this.buttonWhoMade_SDA.Size = new System.Drawing.Size(41, 35);
            this.buttonWhoMade_SDA.TabIndex = 4;
            this.buttonWhoMade_SDA.Text = "?";
            this.buttonWhoMade_SDA.UseVisualStyleBackColor = true;
            this.buttonWhoMade_SDA.Click += new System.EventHandler(this.buttonWhoMade_SDA_Click);
            // 
            // FormMain_SDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWhoMade_SDA);
            this.Controls.Add(this.buttonResult_SDA);
            this.Controls.Add(this.groupBoxResult_SDA);
            this.Controls.Add(this.groupBoxInput_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 29 | Сабаров Д. А.   ";
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).EndInit();
            this.groupBoxInput_SDA.ResumeLayout(false);
            this.groupBoxInput_SDA.PerformLayout();
            this.groupBoxResult_SDA.ResumeLayout(false);
            this.groupBoxResult_SDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.GroupBox groupBoxInput_SDA;
        private System.Windows.Forms.GroupBox groupBoxResult_SDA;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SDA;
        private System.Windows.Forms.Label labelB_SDA;
        private System.Windows.Forms.TextBox textBoxB_SDA;
        private System.Windows.Forms.Button buttonResult_SDA;
        private System.Windows.Forms.Button buttonWhoMade_SDA;
    }
}

