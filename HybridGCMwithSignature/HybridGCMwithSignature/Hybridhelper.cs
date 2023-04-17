//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace HybridGCMwithSignature;

public static class Hybridhelper
{
    private static byte[] ComputeHMACSha256(byte[] messageToBeHashed, byte[] hmacKey)
    {
        using var hmacSha256 = new HMACSHA256(hmacKey);

        return hmacSha256.ComputeHash(messageToBeHashed);
    }

    public static Packethelper EncryptMessage(byte[] message, RSAhelper rsaParams, Signaturehelper digitalSignature)
    {
        var sessionKey = RandomNumberGenerator.GetBytes(32);

        var packetEncypted = new Packethelper { InitializationVector = RandomNumberGenerator.GetBytes(12) };

        (byte[] cipherText, byte[] tag) = GCMhelper.EncryptMessage(message, sessionKey, packetEncypted.InitializationVector, null);

        packetEncypted.EncryptedMessage = cipherText;

        packetEncypted.Tag = tag;

        packetEncypted.EncryptedSessionKey = rsaParams.Encrypt(sessionKey);

        packetEncypted.SignatureHMAC = ComputeHMACSha256(CombineArray(packetEncypted.EncryptedMessage, packetEncypted.InitializationVector), sessionKey);

        packetEncypted.Signature = digitalSignature.SignMessage(packetEncypted.SignatureHMAC);

        return packetEncypted;
    }

    public static byte[] DecryptMessage(Packethelper packetEncypted, RSAhelper rsaParams, Signaturehelper digitalSignature)
    {
        var decryptedSessionKey = rsaParams.Decrypt(packetEncypted.EncryptedSessionKey);

        var newHMAC = ComputeHMACSha256(CombineArray(packetEncypted.EncryptedMessage, packetEncypted.InitializationVector), decryptedSessionKey);

        if (!CompareArray(packetEncypted.SignatureHMAC, newHMAC))
        {
            throw new CryptographicException("The HMAC for decryption does NOT match the encrypted packet!");
        }

        if (!digitalSignature.VerifySignature(packetEncypted.Signature, packetEncypted.SignatureHMAC))
        {
            throw new CryptographicException(" The Digital Signature CANNOT be verified!");
        }

        var decryptedMessage = GCMhelper.DecryptMessage(packetEncypted.EncryptedMessage, decryptedSessionKey, packetEncypted.InitializationVector, packetEncypted.Tag, null);

        return decryptedMessage;
    }

    private static byte[] CombineArray(byte[] first, byte[] second)
    {
        var ret = new byte[first.Length + second.Length];

        Buffer.BlockCopy(first, 0, ret, 0, first.Length);

        Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);

        return ret;
    }

    private static bool CompareArray(byte[] array1, byte[] array2)
    {
        var result = array1.Length == array2.Length;

        for (var i = 0; i < array1.Length && i < array2.Length; ++i)
        {
            result &= array1[i] == array2[i];
        }

        return result;
    }
}
