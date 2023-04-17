//Free & open source.Use this software in your applications as you see fit. 
using System.Security.Cryptography;
using System.Text;

namespace ProtectData;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        var message = textBox4.Text;

        var gcmKey = RandomNumberGenerator.GetBytes(32);

        textBox1.Text = Convert.ToBase64String(gcmKey);

        var nonce = RandomNumberGenerator.GetBytes(12);

        var (encrypted, tag) = EncryptMessage(message, gcmKey, nonce);

        var entropy = RandomNumberGenerator.GetBytes(16);

        var protectedKey = Protectedhelper.Protect(gcmKey, entropy, DataProtectionScope.CurrentUser);

        textBox2.Text = Convert.ToBase64String(protectedKey);

        var decryptedMessage = DecryptMessage(encrypted, nonce, tag, protectedKey, entropy);

        textBox3.Text = decryptedMessage;
    }
    private static (byte[] encrypted, byte[] tag) EncryptMessage(string message, byte[] gcmKey, byte[] nonce)
    {
        return GCMhelper.Encrypt(Encoding.UTF8.GetBytes(message), gcmKey, nonce, Encoding.UTF8.GetBytes("arbitrary metadata"));
    }
    private static string DecryptMessage(byte[] encrypted, byte[] nonce, byte[] tag, byte[] protectedKey, byte[] entropy)
    {
        var key = Protectedhelper.Unprotect(protectedKey, entropy, DataProtectionScope.CurrentUser);

        var decryptedMessage = GCMhelper.Decrypt(encrypted, key, nonce, tag, Encoding.UTF8.GetBytes("arbitrary metadata"));

        return Encoding.UTF8.GetString(decryptedMessage);
    }
}