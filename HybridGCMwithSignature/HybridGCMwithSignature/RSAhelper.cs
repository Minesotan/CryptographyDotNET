//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace HybridGCMwithSignature;

public class RSAhelper
{
    private readonly RSA rsa;

    public RSAhelper()
    {
        rsa = RSA.Create(2048);
    }

    public byte[] Encrypt(byte[] messageToEncrypt)
    {
        return rsa.Encrypt(messageToEncrypt, RSAEncryptionPadding.OaepSHA256);
    }

    public byte[] Decrypt(byte[] messageToDecrypt)
    {
        return rsa.Decrypt(messageToDecrypt, RSAEncryptionPadding.OaepSHA256);
    }
}
