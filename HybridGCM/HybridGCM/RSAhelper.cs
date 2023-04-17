//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace HybridGCM;

public class RSAhelper
{
    private RSAParameters _publicKey;

    private RSAParameters _privateKey;

    public void AssignNewKey()
    {
        var rsa = RSA.Create(2048);

        _publicKey = rsa.ExportParameters(false);

        _privateKey = rsa.ExportParameters(true);
    }
    public byte[] EncryptMessage(byte[] messageToEncrypt)
    {
        var rsa = RSA.Create(2048);

        rsa.ImportParameters(_publicKey);

        var cipherBytes = rsa.Encrypt(messageToEncrypt, RSAEncryptionPadding.OaepSHA256);

        return cipherBytes;
    }
    public byte[] DecryptMessage(byte[] messageToEncrypt)
    {
        var rsa = RSA.Create(2048);

        rsa.ImportParameters(_privateKey);

        var plainText = rsa.Decrypt(messageToEncrypt, RSAEncryptionPadding.OaepSHA256);

        return plainText;
    }
}
