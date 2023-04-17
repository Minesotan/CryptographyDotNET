//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace Hashing;

public static class Hashhelper
{
    public static byte[] ComputeHashSha1(byte[] messageToBeHashed)
    {
        var sha1 = SHA1.Create();
        return sha1.ComputeHash(messageToBeHashed);
    }

    public static byte[] ComputeHashSha256(byte[] messageToBeHashed)
    {
        var sha256 = SHA256.Create();
        return sha256.ComputeHash(messageToBeHashed);
    }

    public static byte[] ComputeHashSha512(byte[] messageToBeHashed)
    {
        var sha512 = SHA512.Create();
        return sha512.ComputeHash(messageToBeHashed);
    }

    public static byte[] ComputeHashMd5(byte[] messageToBeHashed)
    {
        var md5 = MD5.Create();
        return md5.ComputeHash(messageToBeHashed);
    }
}
