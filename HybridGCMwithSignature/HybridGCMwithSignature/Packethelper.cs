//Free & open source. Use this software in your applications as you see fit.
namespace HybridGCMwithSignature;

public class Packethelper
{
    public byte[] EncryptedSessionKey;

    public byte[] EncryptedMessage;

    public byte[] InitializationVector;

    public byte[] Tag;

    public byte[] SignatureHMAC;

    public byte[] Signature;
}
