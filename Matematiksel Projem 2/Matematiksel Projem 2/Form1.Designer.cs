﻿namespace Matematiksel_Projem_2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Toplama = new System.Windows.Forms.RadioButton();
            this.Cıkarma = new System.Windows.Forms.RadioButton();
            this.Bolme = new System.Windows.Forms.RadioButton();
            this.Carpma = new System.Windows.Forms.RadioButton();
            this.Ortalama = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(363, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Sayıy Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Sayıyı Giriniz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Toplama
            // 
            this.Toplama.AutoSize = true;
            this.Toplama.Location = new System.Drawing.Point(366, 247);
            this.Toplama.Name = "Toplama";
            this.Toplama.Size = new System.Drawing.Size(66, 17);
            this.Toplama.TabIndex = 3;
            this.Toplama.TabStop = true;
            this.Toplama.Text = "Toplama";
            this.Toplama.UseVisualStyleBackColor = true;
            // 
            // Cıkarma
            // 
            this.Cıkarma.AutoSize = true;
            this.Cıkarma.Location = new System.Drawing.Point(366, 270);
            this.Cıkarma.Name = "Cıkarma";
            this.Cıkarma.Size = new System.Drawing.Size(63, 17);
            this.Cıkarma.TabIndex = 3;
            this.Cıkarma.TabStop = true;
            this.Cıkarma.Text = "Cıkarma";
            this.Cıkarma.UseVisualStyleBackColor = true;
            // 
            // Bolme
            // 
            this.Bolme.AutoSize = true;
            this.Bolme.Location = new System.Drawing.Point(366, 294);
            this.Bolme.Name = "Bolme";
            this.Bolme.Size = new System.Drawing.Size(54, 17);
            this.Bolme.TabIndex = 4;
            this.Bolme.TabStop = true;
            this.Bolme.Text = "Bolme";
            this.Bolme.UseVisualStyleBackColor = true;
            // 
            // Carpma
            // 
            this.Carpma.AutoSize = true;
            this.Carpma.Location = new System.Drawing.Point(366, 319);
            this.Carpma.Name = "Carpma";
            this.Carpma.Size = new System.Drawing.Size(61, 17);
            this.Carpma.TabIndex = 5;
            this.Carpma.TabStop = true;
            this.Carpma.Text = "Carpma";
            this.Carpma.UseVisualStyleBackColor = true;
            // 
            // Ortalama
            // 
            this.Ortalama.AutoSize = true;
            this.Ortalama.Location = new System.Drawing.Point(366, 342);
            this.Ortalama.Name = "Ortalama";
            this.Ortalama.Size = new System.Drawing.Size(67, 17);
            this.Ortalama.TabIndex = 6;
            this.Ortalama.TabStop = true;
            this.Ortalama.Text = "Ortalama";
            this.Ortalama.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(601, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 596);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Ortalama);
            this.Controls.Add(this.Carpma);
            this.Controls.Add(this.Bolme);
            this.Controls.Add(this.Cıkarma);
            this.Controls.Add(this.Toplama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Toplama;
        private System.Windows.Forms.RadioButton Cıkarma;
        private System.Windows.Forms.RadioButton Bolme;
        private System.Windows.Forms.RadioButton Carpma;
        private System.Windows.Forms.RadioButton Ortalama;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

