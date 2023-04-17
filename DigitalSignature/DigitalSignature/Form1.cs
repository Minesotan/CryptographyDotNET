//Free & open source. Use this software in your applications as you see fit.
using System.Text;

namespace DigitalSignature;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var message = Encoding.UTF8.GetBytes(textBox1.Text);

        var digitalSignature = new Signaturehelper();

        var signature = digitalSignature.SignData(message);

        var valid = digitalSignature.VerifySignature(signature.Item1, signature.Item2);

        textBox2.Text = (valid ? "The digital signature is VALID" : "The digital signature is INVALID");

        textBox3.Text = Convert.ToBase64String(signature.Item1);
    }
}