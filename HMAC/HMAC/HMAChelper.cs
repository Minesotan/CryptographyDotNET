//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace HMAC;

public static class HMAChelper
{
    public static byte[] ComputeHmacsha256(byte[] messageToBeHashed, byte[] key)
    {
        var hmac = new HMACSHA256(key);

        return hmac.ComputeHash(messageToBeHashed);
    }

    public static byte[] ComputeHmacsha1(byte[] messageToBeHashed, byte[] key)
    {
        var hmac = new HMACSHA1(key);

        return hmac.ComputeHash(messageToBeHashed);
    }

    public static byte[] ComputeHmacsha512(byte[] messageToBeHashed, byte[] key)
    {
        var hmac = new HMACSHA512(key);

        return hmac.ComputeHash(messageToBeHashed);
    }

    public static byte[] ComputeHmacmd5(byte[] messageToBeHashed, byte[] key)
    {
        var hmac = new HMACMD5(key);

        return hmac.ComputeHash(messageToBeHashed);
    }
}
