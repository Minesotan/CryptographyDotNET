﻿namespace Derivation
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
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 32);
            label1.Name = "label1";
            label1.Size = new Size(965, 50);
            label1.TabIndex = 0;
            label1.Text = "Created by Rod Morabito and Derek Walker for CYBR-432";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 139);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter a password to hash.";
            textBox1.Size = new Size(501, 29);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(789, 115);
            button1.Name = "button1";
            button1.Size = new Size(177, 74);
            button1.TabIndex = 2;
            button1.Text = "Hash";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(611, 29);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(871, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 29);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(186, 383);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(611, 29);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(871, 383);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 29);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(186, 491);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(611, 29);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(871, 491);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(187, 29);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(186, 599);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(611, 29);
            textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(871, 599);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(187, 29);
            textBox9.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 225);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 11;
            label2.Text = "100 Iterations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(186, 336);
            label3.Name = "label3";
            label3.Size = new Size(174, 30);
            label3.TabIndex = 12;
            label3.Text = "50,000 Iterations";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(186, 445);
            label4.Name = "label4";
            label4.Size = new Size(203, 30);
            label4.TabIndex = 13;
            label4.Text = "1,000,000 Iterations";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(186, 556);
            label5.Name = "label5";
            label5.Size = new Size(203, 30);
            label5.TabIndex = 14;
            label5.Text = "3,000,000 Iterations";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(821, 216);
            label6.Name = "label6";
            label6.Size = new Size(283, 30);
            label6.TabIndex = 15;
            label6.Text = "Time to Hash in Miliseconds";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(label6);
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
            Text = "Password Based Key Derivation";
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
        private Label label6;
    }
}