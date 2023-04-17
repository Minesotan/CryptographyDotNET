//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;
using System.Text;

namespace HMAC;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string message = textBox1.Text;

        var key1 = RandomNumberGenerator.GetBytes(32);
        var key2 = RandomNumberGenerator.GetBytes(32);

        var hmacMd5Message = HMAChelper.ComputeHmacmd5(Encoding.UTF8.GetBytes(message), key1);
        var hmacMd5Message2 = HMAChelper.ComputeHmacmd5(Encoding.UTF8.GetBytes(message), key2);

        var hmacSha1Message = HMAChelper.ComputeHmacsha1(Encoding.UTF8.GetBytes(message), key1);
        var hmacSha1Message2 = HMAChelper.ComputeHmacsha1(Encoding.UTF8.GetBytes(message), key2);

        var hmacSha256Message = HMAChelper.ComputeHmacsha256(Encoding.UTF8.GetBytes(message), key1);
        var hmacSha256Message2 = HMAChelper.ComputeHmacsha256(Encoding.UTF8.GetBytes(message), key2);

        var hmacSha512Message = HMAChelper.ComputeHmacsha512(Encoding.UTF8.GetBytes(message), key1);
        var hmacSha512Message2 = HMAChelper.ComputeHmacsha512(Encoding.UTF8.GetBytes(message), key2);

        textBox2.Text = Convert.ToBase64String(hmacMd5Message);
        textBox3.Text = Convert.ToBase64String(hmacMd5Message2);

        textBox4.Text = Convert.ToBase64String(hmacSha1Message);
        textBox5.Text = Convert.ToBase64String(hmacSha1Message2);

        textBox6.Text = Convert.ToBase64String(hmacSha256Message);
        textBox7.Text = Convert.ToBase64String(hmacSha256Message2);

        textBox8.Text = Convert.ToBase64String(hmacSha512Message);
        textBox9.Text = Convert.ToBase64String(hmacSha512Message2);
    }
}