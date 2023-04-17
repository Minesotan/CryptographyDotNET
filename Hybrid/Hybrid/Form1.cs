//Free & open source. Use this software in your applications as you see fit.
using System.Text;

namespace Hybrid;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string message = textBox1.Text;

        var rsaParams = new RSAhelper();

        var encryptedData = Hybridhelper.EncryptData(Encoding.UTF8.GetBytes(message), rsaParams);

        var decryptedMessage = Hybridhelper.DecryptData(encryptedData, rsaParams);

        textBox2.Text = Convert.ToBase64String(encryptedData.EncryptedMessage);

        textBox3.Text = Encoding.UTF8.GetString(decryptedMessage);

        textBox4.Text = Convert.ToBase64String(encryptedData.EncryptedSessionKey);
    }
}