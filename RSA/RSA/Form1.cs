//Free & open source.Use this software in your applications as you see fit.
using System.Security.Cryptography; 
using System.Text;

namespace MY_RSA;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        RSAEncryptDecrypt();

        RSAEncryptDecryptWithKeyExport();
    }

    private void RSAEncryptDecrypt()
    {
        var rsa = new RSAhelper();

        var message = textBox1.Text;

        var encryptedMessage = rsa.Encrypt(message);

        var decryptedMessage = rsa.Decrypt(encryptedMessage);

        textBox2.Text = Convert.ToBase64String(encryptedMessage);

        textBox4.Text = Encoding.Default.GetString(decryptedMessage);
    }

    private void RSAEncryptDecryptWithKeyExport()
    {
        var rsa = new RSAhelper();

        var password = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));

        byte[] encryptedPrivateKey = rsa.ExportPrivateKey(100000, password);

        byte[] publicKey = rsa.ExportPublicKey();

        var message = textBox1.Text;

        var encryptedMessage = rsa.Encrypt(message);

        var rsa2 = new RSAhelper();

        rsa2.ImportPublicKey(publicKey);

        rsa2.ImportEncryptedPrivateKey(encryptedPrivateKey, password);

        var decryptedMessage = rsa2.Decrypt(encryptedMessage);

        textBox3.Text = Convert.ToBase64String(encryptedMessage);

        textBox5.Text = Encoding.Default.GetString(decryptedMessage);
    }
}