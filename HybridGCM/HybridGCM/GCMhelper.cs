//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace HybridGCM;

public static class GCMhelper
{
    public static (byte[], byte[]) Encrypt(byte[] messageToEncrypt, byte[] key, byte[] nonce, byte[] associatedData)
    {
        var tag = new byte[16];

        var cipherText = new byte[messageToEncrypt.Length];

        var aesGcm = new AesGcm(key);

        aesGcm.Encrypt(nonce, messageToEncrypt, cipherText, tag, associatedData);

        return (cipherText, tag);
    }

    public static byte[] Decrypt(byte[] cipherText, byte[] key, byte[] nonce, byte[] tag, byte[] associatedData)
    {
        var decryptedMessage = new byte[cipherText.Length];

        var aesGcm = new AesGcm(key);

        aesGcm.Decrypt(nonce, cipherText, tag, decryptedMessage, associatedData);

        return decryptedMessage;
    }
}
