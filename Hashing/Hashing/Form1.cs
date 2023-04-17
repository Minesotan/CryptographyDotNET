//Free & open source. Use this software in your applications as you see fit.
using System.Text;

namespace Hashing;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string firstMessage = textBox1.Text;
        string secondMessage = textBox10.Text;

        var md5HashedMessage = Hashhelper.ComputeHashMd5(Encoding.UTF8.GetBytes(firstMessage));
        var md5HashedMessage2 = Hashhelper.ComputeHashMd5(Encoding.UTF8.GetBytes(secondMessage));

        var sha1HashedMessage = Hashhelper.ComputeHashSha1(Encoding.UTF8.GetBytes(firstMessage));
        var sha1HashedMessage2 = Hashhelper.ComputeHashSha1(Encoding.UTF8.GetBytes(secondMessage));

        var sha256HashedMessage = Hashhelper.ComputeHashSha256(Encoding.UTF8.GetBytes(firstMessage));
        var sha256HashedMessage2 = Hashhelper.ComputeHashSha256(Encoding.UTF8.GetBytes(secondMessage));

        var sha512HashedMessage = Hashhelper.ComputeHashSha512(Encoding.UTF8.GetBytes(firstMessage));
        var sha512HashedMessage2 = Hashhelper.ComputeHashSha512(Encoding.UTF8.GetBytes(secondMessage));

        textBox2.Text = Convert.ToBase64String(md5HashedMessage);
        textBox3.Text = Convert.ToBase64String(md5HashedMessage2);

        textBox4.Text = Convert.ToBase64String(sha1HashedMessage);
        textBox5.Text = Convert.ToBase64String(sha1HashedMessage2);

        textBox6.Text = Convert.ToBase64String(sha256HashedMessage);
        textBox7.Text = Convert.ToBase64String(sha256HashedMessage2);

        textBox8.Text = Convert.ToBase64String(sha512HashedMessage);
        textBox9.Text = Convert.ToBase64String(sha512HashedMessage2);
    }
}