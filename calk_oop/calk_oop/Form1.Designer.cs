﻿namespace calk_oop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Lg = new System.Windows.Forms.Button();
            this.Neg = new System.Windows.Forms.Button();
            this.Pw = new System.Windows.Forms.Button();
            this.Pwr = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Pwer = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.Avg = new System.Windows.Forms.Button();
            this.GeomAvg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 59);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Calk);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(103, 59);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(75, 23);
            this.Subtraction.TabIndex = 1;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Calk);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(198, 59);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 2;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Calk);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(297, 59);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Calk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(574, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(703, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(12, 100);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 7;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(103, 100);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 8;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(198, 100);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(75, 23);
            this.Exp.TabIndex = 9;
            this.Exp.Text = "Exp";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(297, 100);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(75, 23);
            this.Tan.TabIndex = 10;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(12, 141);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(75, 25);
            this.Arcsin.TabIndex = 11;
            this.Arcsin.Text = "ArcSin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(103, 142);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(75, 23);
            this.Arccos.TabIndex = 12;
            this.Arccos.Text = "ArcCos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Arctan
            // 
            this.Arctan.Location = new System.Drawing.Point(198, 143);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(75, 23);
            this.Arctan.TabIndex = 13;
            this.Arctan.Text = "ArcTan";
            this.Arctan.UseVisualStyleBackColor = true;
            this.Arctan.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(297, 142);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(75, 24);
            this.Abs.TabIndex = 14;
            this.Abs.Text = "Module";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(12, 185);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(75, 23);
            this.Ln.TabIndex = 15;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(103, 185);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(75, 23);
            this.Pow.TabIndex = 16;
            this.Pow.Text = "Pow";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.Calk);
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(198, 185);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(75, 23);
            this.Power.TabIndex = 17;
            this.Power.Text = "x^(1/y)";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Calk);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(297, 185);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(75, 23);
            this.Log.TabIndex = 18;
            this.Log.Text = "Logx(y)";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Calk);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(12, 225);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(75, 23);
            this.Min.TabIndex = 19;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Calk);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(103, 225);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(75, 23);
            this.Max.TabIndex = 20;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Calk);
            // 
            // Lg
            // 
            this.Lg.Location = new System.Drawing.Point(198, 225);
            this.Lg.Name = "Lg";
            this.Lg.Size = new System.Drawing.Size(75, 23);
            this.Lg.TabIndex = 21;
            this.Lg.Text = "Lg";
            this.Lg.UseVisualStyleBackColor = true;
            this.Lg.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Neg
            // 
            this.Neg.Location = new System.Drawing.Point(297, 225);
            this.Neg.Name = "Neg";
            this.Neg.Size = new System.Drawing.Size(75, 23);
            this.Neg.TabIndex = 22;
            this.Neg.Text = "-x";
            this.Neg.UseVisualStyleBackColor = true;
            this.Neg.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Pw
            // 
            this.Pw.Location = new System.Drawing.Point(12, 263);
            this.Pw.Name = "Pw";
            this.Pw.Size = new System.Drawing.Size(75, 23);
            this.Pw.TabIndex = 23;
            this.Pw.Text = "2^x";
            this.Pw.UseVisualStyleBackColor = true;
            this.Pw.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Pwr
            // 
            this.Pwr.Location = new System.Drawing.Point(103, 263);
            this.Pwr.Name = "Pwr";
            this.Pwr.Size = new System.Drawing.Size(75, 23);
            this.Pwr.TabIndex = 24;
            this.Pwr.Text = "10^x";
            this.Pwr.UseVisualStyleBackColor = true;
            this.Pwr.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(198, 263);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 25;
            this.Back.Text = "1/x";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Pwer
            // 
            this.Pwer.Location = new System.Drawing.Point(297, 263);
            this.Pwer.Name = "Pwer";
            this.Pwer.Size = new System.Drawing.Size(75, 23);
            this.Pwer.TabIndex = 26;
            this.Pwer.Text = "x^2";
            this.Pwer.UseVisualStyleBackColor = true;
            this.Pwer.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Ctg
            // 
            this.Ctg.Location = new System.Drawing.Point(12, 301);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(75, 23);
            this.Ctg.TabIndex = 27;
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.OneArgumentCalk);
            // 
            // Avg
            // 
            this.Avg.Location = new System.Drawing.Point(103, 301);
            this.Avg.Name = "Avg";
            this.Avg.Size = new System.Drawing.Size(75, 23);
            this.Avg.TabIndex = 28;
            this.Avg.Text = "Average";
            this.Avg.UseVisualStyleBackColor = true;
            this.Avg.Click += new System.EventHandler(this.Calk);
            // 
            // GeomAvg
            // 
            this.GeomAvg.Location = new System.Drawing.Point(198, 301);
            this.GeomAvg.Name = "GeomAvg";
            this.GeomAvg.Size = new System.Drawing.Size(75, 23);
            this.GeomAvg.TabIndex = 29;
            this.GeomAvg.Text = "AverageGeom";
            this.GeomAvg.UseVisualStyleBackColor = true;
            this.GeomAvg.Click += new System.EventHandler(this.Calk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(431, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Первое значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(579, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Второе значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(695, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeomAvg);
            this.Controls.Add(this.Avg);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Pwer);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Pwr);
            this.Controls.Add(this.Pw);
            this.Controls.Add(this.Neg);
            this.Controls.Add(this.Lg);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button Abs;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Lg;
        private System.Windows.Forms.Button Neg;
        private System.Windows.Forms.Button Pw;
        private System.Windows.Forms.Button Pwr;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Pwer;
        private System.Windows.Forms.Button Ctg;
        private System.Windows.Forms.Button Avg;
        private System.Windows.Forms.Button GeomAvg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

