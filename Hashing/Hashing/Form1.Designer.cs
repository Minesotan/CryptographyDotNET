namespace Hashing
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            textBox10 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 18);
            label1.Name = "label1";
            label1.Size = new Size(965, 50);
            label1.TabIndex = 0;
            label1.Text = "Created by Rod Morabito and Derek Walker for CYBR-432";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 247);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.TabIndex = 1;
            label2.Text = "MD5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 389);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 2;
            label3.Text = "SHA-1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(159, 536);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 3;
            label4.Text = "SHA-256";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(159, 673);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 4;
            label5.Text = "SHA-512";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 117);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter a message to hash.";
            textBox1.Size = new Size(466, 29);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(683, 125);
            button1.Name = "button1";
            button1.Size = new Size(203, 84);
            button1.TabIndex = 6;
            button1.Text = "Hash";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 289);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Message 1 hash";
            textBox2.Size = new Size(943, 29);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 342);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Message 2 hash";
            textBox3.Size = new Size(943, 29);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 433);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Message 1 hash";
            textBox4.Size = new Size(943, 29);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(159, 484);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Message 2 hash";
            textBox5.Size = new Size(943, 29);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(159, 581);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Message 1 hash";
            textBox6.Size = new Size(943, 29);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(159, 629);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Message 2 hash";
            textBox7.Size = new Size(943, 29);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(159, 718);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Message 1 hash";
            textBox8.Size = new Size(943, 29);
            textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(159, 772);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Message 2 hash";
            textBox9.Size = new Size(943, 29);
            textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(159, 180);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Enter a second message to hash.";
            textBox10.Size = new Size(466, 29);
            textBox10.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 837);
            Controls.Add(textBox10);
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
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Hashing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
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
        private TextBox textBox10;
    }
}