//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;
using System.Text;

namespace HybridGCMwithSignature;

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

        var digitalSignature = new Signaturehelper();

        try
        {
            var encryptedMessage = Hybridhelper.EncryptMessage(Encoding.UTF8.GetBytes(message), rsaParams, digitalSignature);

            var decryptedMessage = Hybridhelper.DecryptMessage(encryptedMessage, rsaParams, digitalSignature);

            textBox2.Text = Convert.ToBase64String(encryptedMessage.EncryptedMessage);

            textBox3.Text = Encoding.UTF8.GetString(decryptedMessage);

            textBox4.Text = Convert.ToBase64String(encryptedMessage.EncryptedSessionKey);

            textBox5.Text = Convert.ToBase64String(encryptedMessage.Signature);
        }
        catch (CryptographicException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}