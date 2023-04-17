//Free & open source. Use this software in your applications as you see fit.
using System.Diagnostics;
using System.Security.Cryptography;

namespace Derivation;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string passwordToHash = textBox1.Text;

        var sw1 = Stopwatch.StartNew();
        var hashedPassword1 = Rfc2898DeriveBytes.Pbkdf2(passwordToHash, RandomNumberGenerator.GetBytes(32), 100, HashAlgorithmName.SHA256, 32);
        sw1.Stop();
        textBox2.Text = Convert.ToBase64String(hashedPassword1);
        textBox3.Text = Convert.ToString(sw1.ElapsedMilliseconds);

        var sw2 = Stopwatch.StartNew();
        var hashedPassword2 = Rfc2898DeriveBytes.Pbkdf2(passwordToHash, RandomNumberGenerator.GetBytes(32), 50000, HashAlgorithmName.SHA256, 32);
        sw2.Stop();
        textBox4.Text = Convert.ToBase64String(hashedPassword2);
        textBox5.Text = Convert.ToString(sw2.ElapsedMilliseconds);

        var sw3 = Stopwatch.StartNew();
        var hashedPassword3 = Rfc2898DeriveBytes.Pbkdf2(passwordToHash, RandomNumberGenerator.GetBytes(32), 1000000, HashAlgorithmName.SHA256, 32);
        sw3.Stop();
        textBox6.Text = Convert.ToBase64String(hashedPassword3);
        textBox7.Text = Convert.ToString(sw3.ElapsedMilliseconds);

        var sw4 = Stopwatch.StartNew();
        var hashedPassword4 = Rfc2898DeriveBytes.Pbkdf2(passwordToHash, RandomNumberGenerator.GetBytes(32), 3000000, HashAlgorithmName.SHA256, 32);
        sw4.Stop();
        textBox8.Text = Convert.ToBase64String(hashedPassword4);
        textBox9.Text = Convert.ToString(sw4.ElapsedMilliseconds);

    }
}