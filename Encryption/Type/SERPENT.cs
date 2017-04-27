using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JGEncryption.Encryption.Interfaces;
using JGEncryption.Encryption.Proprities;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;

namespace JGEncryption.Encryption.Type
{
  //class SERPENT : SuperClass.Encryption
  //{
    //public SERPENT() : base(new BinaryKey(256), new BinaryKey(128), encryptBiavior, decryptBiavior){}
    //public SERPENT(byte[] secretKey, byte[] utilitykey, IEncryptBehavior encryptBiavior, IDecryptBehavior decryptBiavior) : base(secretKey, utilitykey, encryptBiavior, decryptBiavior)
    //{
    //}
    //AesEngine engine = new AesEngine();
    //CbcBlockCipher blockCipher = new CbcBlockCipher(engine);
    //PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(blockCipher);
    //KeyParameter keyParam = new KeyParameter(self.SecretKey.Value);
    //ParametersWithIV keyParamWithIV = new ParametersWithIV(keyParam, self.UtilityKey.Value, 0, 16);

    //cipher.Init(true, keyParamWithIV);
    //encryptedData = new byte[cipher.GetOutputSize(dataToEncrypt.Length)];
    //int length = cipher.ProcessBytes(dataToEncrypt, encryptedData, 0);
    //cipher.DoFinal(encryptedData, length); 
    //class SerpentEncruptionBihavior : IEncryptBehavior
    //{
    //  public byte[] Encript(byte[] dataToEncrypt, SuperClass.Encryption sef)
    //  {
    //    SerpentEngine engine = new SerpentEngine();
    //    CbcBlockCipher cupher = new CbcBlockCipher();
    //  }
    //}
    
  //}
}
