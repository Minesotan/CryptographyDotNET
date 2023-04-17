//Free & open source.Use this software in your applications as you see fit. 
using System.Security.Cryptography;
using System.Text;

namespace MY_RSA;

internal class RSAhelper
{
    private readonly RSA _rsa;
    public RSAhelper()
    {
        _rsa = RSA.Create(2048);
    }
    public byte[] Encrypt(string messageToEncrypt)
    {
        return _rsa.Encrypt(Encoding.UTF8.GetBytes(messageToEncrypt), RSAEncryptionPadding.OaepSHA256);
    }
    public byte[] Decrypt(byte[] messageToDecrypt)
    {
        return _rsa.Decrypt(messageToDecrypt, RSAEncryptionPadding.OaepSHA256);
    }
    public byte[] ExportPrivateKey(int numberOfIterations, string password)
    {
        var keyParams = new PbeParameters(PbeEncryptionAlgorithm.Aes256Cbc, HashAlgorithmName.SHA256, numberOfIterations);

        var encryptedPrivateKey = _rsa.ExportEncryptedPkcs8PrivateKey(Encoding.UTF8.GetBytes(password), keyParams);

        return encryptedPrivateKey;
    }
    public void ImportEncryptedPrivateKey(byte[] encryptedKey, string password)
    {
        _rsa.ImportEncryptedPkcs8PrivateKey(Encoding.UTF8.GetBytes(password), encryptedKey, out _);
    }
    public byte[] ExportPublicKey()
    {
        return _rsa.ExportRSAPublicKey();
    }
    public void ImportPublicKey(byte[] publicKey)
    {
        _rsa.ImportRSAPublicKey(publicKey, out _);
    }
}
