﻿namespace HMAC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 37);
            label1.Name = "label1";
            label1.Size = new Size(965, 50);
            label1.TabIndex = 0;
            label1.Text = "Created by Rod Morabito and Derek Walker for CYBR-432";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 142);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter a message to hash.";
            textBox1.Size = new Size(491, 29);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(760, 118);
            button1.Name = "button1";
            button1.Size = new Size(177, 74);
            button1.TabIndex = 2;
            button1.Text = "Hash";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 249);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Hashed with key #1:";
            textBox2.Size = new Size(879, 29);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 300);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Hashed with key #2:";
            textBox3.Size = new Size(879, 29);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 399);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Hashed with key #1:";
            textBox4.Size = new Size(879, 29);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(181, 459);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Hashed with key #2:";
            textBox5.Size = new Size(879, 29);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(181, 554);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Hashed with key #1:";
            textBox6.Size = new Size(879, 29);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(181, 608);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Hashed with key #2:";
            textBox7.Size = new Size(879, 29);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(181, 715);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Hashed with key #1:";
            textBox8.Size = new Size(879, 29);
            textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(181, 771);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Hashed with key #2:";
            textBox9.Size = new Size(879, 29);
            textBox9.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(181, 197);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 11;
            label2.Text = "MD5 HMAC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(181, 355);
            label3.Name = "label3";
            label3.Size = new Size(151, 30);
            label3.TabIndex = 12;
            label3.Text = "SHA-1 HMAC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(181, 511);
            label4.Name = "label4";
            label4.Size = new Size(170, 30);
            label4.TabIndex = 13;
            label4.Text = "SHA-256 HMAC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(181, 673);
            label5.Name = "label5";
            label5.Size = new Size(170, 30);
            label5.TabIndex = 14;
            label5.Text = "SHA-512 HMAC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 828);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "HMAC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}