//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace DigitalSignature;

internal class Signaturehelper
{
    private readonly RSA rsa;

    public Signaturehelper()
    {
        rsa = RSA.Create(2048);
    }

    public static byte[] ComputeHashSha256(byte[] toBeHashed)
    {
        var sha256 = SHA256.Create();
        return sha256.ComputeHash(toBeHashed);
    }

    public (byte[], byte[]) SignData(byte[] dataToSign)
    {
        var hashOfDataToSign = ComputeHashSha256(dataToSign);

        return (rsa.SignHash(hashOfDataToSign, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1), hashOfDataToSign);
    }

    public bool VerifySignature(byte[] signature, byte[] hashOfDataToSign)
    {
        return rsa.VerifyHash(hashOfDataToSign, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
    }
}
