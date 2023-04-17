//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace HybridGCM;

public class Hybridhelper
{
    public static Packethelper EncryptMessage(byte[] original, RSAhelper rsaParams)
    {
        var sessionKey = RandomNumberGenerator.GetBytes(32);

        var encryptedPacket = new Packethelper { Nonce = RandomNumberGenerator.GetBytes(12) };

        (byte[] cipherText, byte[] tag) = GCMhelper.Encrypt(original, sessionKey, encryptedPacket.Nonce, null);

        encryptedPacket.EncryptedMessage = cipherText;

        encryptedPacket.Tag = tag;

        encryptedPacket.EncryptedSessionKey = rsaParams.EncryptMessage(sessionKey);

        return encryptedPacket;
    }

    public static byte[] DecryptMessage(Packethelper encryptedPacket, RSAhelper rsaParams)
    {
        var decryptedSessionKey = rsaParams.DecryptMessage(encryptedPacket.EncryptedSessionKey);

        var decryptedMessage = GCMhelper.Decrypt(encryptedPacket.EncryptedMessage, decryptedSessionKey, encryptedPacket.Nonce, encryptedPacket.Tag, null);

        return decryptedMessage;
    }
}
