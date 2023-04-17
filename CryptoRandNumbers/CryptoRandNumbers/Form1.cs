//Free & open source. Use this software in your applications as you see fit.  

using System.Security.Cryptography;

namespace CryptoRandNumbers;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        textBox1.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox2.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox3.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox4.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox5.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox6.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox7.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox8.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox9.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        textBox10.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
    }
}