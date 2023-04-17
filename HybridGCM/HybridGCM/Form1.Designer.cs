namespace HybridGCM
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
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 70);
            label1.Name = "label1";
            label1.Size = new Size(965, 50);
            label1.TabIndex = 0;
            label1.Text = "Created by Rod Morabito and Derek Walker for CYBR-432";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 217);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter a message to encrypt.";
            textBox1.Size = new Size(480, 29);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(782, 197);
            button1.Name = "button1";
            button1.Size = new Size(162, 67);
            button1.TabIndex = 2;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 412);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(463, 29);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(690, 412);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(463, 29);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 352);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 5;
            label2.Text = "Encrypted Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(690, 352);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 6;
            label3.Text = "Decrypted Text:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(87, 530);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1066, 115);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(87, 484);
            label4.Name = "label4";
            label4.Size = new Size(235, 30);
            label4.TabIndex = 8;
            label4.Text = "Encrypted Session Key:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Hybrid Encryption with GCM and Integrity Check";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
    }
}