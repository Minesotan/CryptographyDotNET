//Free & open source.Use this software in your applications as you see fit.  
using System.Security.Cryptography;

namespace AES;

public static class GCMhelper
{
    public static (byte[], byte[]) Encrypt(byte[] dataToEncrypt, byte[] key, byte[] nonce, byte[] associatedData)
    {
        var tag = new byte[16];

        var cipherText = new byte[dataToEncrypt.Length];

        var aesGcm = new AesGcm(key);

        aesGcm.Encrypt(nonce, dataToEncrypt, cipherText, tag, associatedData);

        return (cipherText, tag);
    }

    public static byte[] Decrypt(byte[] cipherText, byte[] key, byte[] nonce, byte[] tag, byte[] associatedData)
    {
        var decryptedText = new byte[cipherText.Length];

        var aesGcm = new AesGcm(key);

        aesGcm.Decrypt(nonce, cipherText, tag, decryptedText, associatedData);

        return decryptedText;
    }
}
