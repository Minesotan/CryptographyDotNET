//Free & open source.Use this software in your applications as you see fit. 
using System.Security.Cryptography;

namespace ProtectData;

public static class Protectedhelper
{
    public static byte[] Protect(byte[] stringToEncrypt, byte[] optionalEntropy, DataProtectionScope scope)
    {
        var encryptedMessage = ProtectedData.Protect(stringToEncrypt, optionalEntropy, scope);

        return encryptedMessage;
    }

    public static byte[] Unprotect(byte[] encryptedString, byte[] optionalEntropy, DataProtectionScope scope)
    {
        var decryptedMessage = ProtectedData.Unprotect(encryptedString, optionalEntropy, scope);

        return decryptedMessage;
    }
}
