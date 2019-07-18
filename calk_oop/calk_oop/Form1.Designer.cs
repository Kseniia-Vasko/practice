namespace calk_oop
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
            this.Add = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
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
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(311, 24);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

