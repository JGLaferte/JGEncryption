using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JGEncryption.Encryption.Interfaces;
using JGEncryption.Encryption.Proprities;

namespace JGEncryption.Encryption.SuperClass
{
  public abstract class Encryption : IEncryption
  {
    public ISecretKey SecretKey { get; set; }
    public IUtilityKey UtilityKey { get; set; }


    private readonly IEncryptBehavior _encryptBiavior;
    private readonly IDecryptBehavior _decryptBiavior;

    protected Encryption(ISecretKey secretKey, IUtilityKey utilityKey, IEncryptBehavior encryptBiavior,
      IDecryptBehavior decryptBiavior)
    {
      SecretKey = secretKey;
      UtilityKey = utilityKey;
      _encryptBiavior = encryptBiavior;
      _decryptBiavior = decryptBiavior;
    }
    protected Encryption(byte[] secretKey, byte[] utilitykey, IEncryptBehavior encryptBiavior, IDecryptBehavior decryptBiavior)
    {
      SecretKey = new BinaryKey(secretKey);
      UtilityKey = new BinaryKey(utilitykey);
      _encryptBiavior = encryptBiavior;
      _decryptBiavior = decryptBiavior;
    }

    public byte[] GetSecretKey()
    {
      return this.SecretKey.Value;
    }

    public byte[] GetUtilityKey()
    {
      return this.UtilityKey.Value;
    }

    public byte[]  Encrypt(byte[] dataToEncrypt)
    {
      return this._encryptBiavior.Encript(dataToEncrypt, this);
    }

    public byte[] Decrypt(byte[] dataToDecrypt)
    {
      return this._decryptBiavior.Decrypt(dataToDecrypt, this);
    }




  }
}
