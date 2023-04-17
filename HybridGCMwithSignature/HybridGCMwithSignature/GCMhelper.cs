//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace HybridGCMwithSignature;

public static class GCMhelper
{
    public static (byte[], byte[]) EncryptMessage(byte[] dataToEncrypt, byte[] key, byte[] nonce, byte[] associatedData)
    {
        var tag = new byte[16];

        var cipherText = new byte[dataToEncrypt.Length];

        AesGcm aesGcm = new(key);

        aesGcm.Encrypt(nonce, dataToEncrypt, cipherText, tag, associatedData);

        return (cipherText, tag);
    }

    public static byte[] DecryptMessage(byte[] cipherText, byte[] key, byte[] nonce, byte[] tag, byte[] associatedData)
    {
        var decryptedMessage = new byte[cipherText.Length];

        AesGcm aesGcm = new(key);

        aesGcm.Decrypt(nonce, cipherText, tag, decryptedMessage, associatedData);

        return decryptedMessage;
    }
}
