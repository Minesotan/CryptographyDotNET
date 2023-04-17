//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace HybridGCMwithSignature;

public class Signaturehelper
{
    private readonly RSA rsa;

    public Signaturehelper()
    {
        rsa = RSA.Create(2048);
    }

    public byte[] SignMessage(byte[] messageToSign)
    {
        return rsa.SignHash(messageToSign, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
    }

    public bool VerifySignature(byte[] signature, byte[] hashOfDataToSign)
    {
        return rsa.VerifyHash(hashOfDataToSign, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
    }
}
