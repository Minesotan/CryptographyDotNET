//Free & open source. Use this software in your applications as you see fit.
using System.Security.Cryptography;

namespace Hybrid;

public class Hybridhelper
{
    public static Packethelper EncryptData(byte[] message, RSAhelper rsaParams)
    {
        var sessionKey = RandomNumberGenerator.GetBytes(32);

        var encryptedPacket = new Packethelper { initializationVector = RandomNumberGenerator.GetBytes(16) };

        encryptedPacket.EncryptedMessage = CBChelper.Encrypt(message, sessionKey, encryptedPacket.initializationVector);

        encryptedPacket.EncryptedSessionKey = rsaParams.Encrypt(sessionKey);

        return encryptedPacket;
    }

    public static byte[] DecryptData(Packethelper encryptedPacket, RSAhelper rsaParams)
    {
        var decryptedSessionKey = rsaParams.Decrypt(encryptedPacket.EncryptedSessionKey);

        var decryptedMessage = CBChelper.Decrypt(encryptedPacket.EncryptedMessage, decryptedSessionKey, encryptedPacket.initializationVector);

        return decryptedMessage;
    }
}
