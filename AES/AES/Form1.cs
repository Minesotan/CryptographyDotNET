//Free & open source.Use this software in your applications as you see fit. 
using System.Security.Cryptography;
using System.Text;

namespace AES;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        AesGCM();

        AesCBC();
    }
    private void AesCBC()
    {
        string message = textBox1.Text;

        var key = RandomNumberGenerator.GetBytes(32);

        var initializationVector = RandomNumberGenerator.GetBytes(16);

        var encryptedMessage = CBChelper.Encrypt(Encoding.UTF8.GetBytes(message), key, initializationVector);

        var decryptedMessage = CBChelper.Decrypt(encryptedMessage, key, initializationVector);

        textBox2.Text = Convert.ToBase64String(encryptedMessage);

        textBox3.Text = Encoding.UTF8.GetString(decryptedMessage);
    }
    private void AesGCM()
    {
        string message = textBox1.Text;

        var key = RandomNumberGenerator.GetBytes(32);

        var nonce = RandomNumberGenerator.GetBytes(12);

        (byte[] cipherText, byte[] tag) = GCMhelper.Encrypt(Encoding.UTF8.GetBytes(message), key, nonce, Encoding.UTF8.GetBytes("arbitrary metadata"));

        byte[] decryptedMessage = GCMhelper.Decrypt(cipherText, key, nonce, tag, Encoding.UTF8.GetBytes("arbitrary metadata"));

        textBox4.Text = Convert.ToBase64String(cipherText);

        textBox5.Text = Encoding.UTF8.GetString(decryptedMessage);
    }
}