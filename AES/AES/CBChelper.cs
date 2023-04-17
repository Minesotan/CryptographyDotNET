//Free & open source.Use this software in your applications as you see fit. 
using System.Security.Cryptography;

namespace AES;

public static class CBChelper
{
    public static byte[] Encrypt(byte[] messageToEncrypt, byte[] key, byte[] initializationVector)
    {
        var aes = Aes.Create();

        aes.Key = key;

        return aes.EncryptCbc(messageToEncrypt, initializationVector);
    }

    public static byte[] Decrypt(byte[] messageToDecrypt, byte[] key, byte[] initializationVector)
    {
        var aes = Aes.Create();

        aes.Key = key;

        return aes.DecryptCbc(messageToDecrypt, initializationVector);
    }
}
