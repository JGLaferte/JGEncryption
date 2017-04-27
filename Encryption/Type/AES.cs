using JGEncryption.Encryption.Biaviors;
using JGEncryption.Encryption.Proprities;

namespace JGEncryption.Encryption.Type
{
  public class AES : SuperClass.Encryption
  {
    public AES() :
      base(new BinaryKey(256), new BinaryKey(128), new AESEncriptBehavior(), new AESDecryptorBehavior()){}

    public AES(byte[] secretKey, byte[] utilitykey) :
      base(secretKey, utilitykey, new AESEncriptBehavior(), new AESDecryptorBehavior()){}
  }
}
