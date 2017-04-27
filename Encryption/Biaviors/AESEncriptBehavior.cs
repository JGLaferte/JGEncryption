using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle;
using JGEncryption.Encryption.Interfaces;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace JGEncryption.Encryption.Biaviors
{
  //AesEngine engine = new AesEngine();
  //CbcBlockCipher blockCipher = new CbcBlockCipher(engine);
  //PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(blockCipher);
  //KeyParameter keyParam = new KeyParameter(self.SecretKey.Value);
  //ParametersWithIV keyParamWithIV = new ParametersWithIV(keyParam, self.UtilityKey.Value, 0, 16);

  //cipher.Init(true, keyParamWithIV);
  //encryptedData = new byte[cipher.GetOutputSize(dataToEncrypt.Length)];
  //int length = cipher.ProcessBytes(dataToEncrypt, encryptedData, 0);
  //cipher.DoFinal(encryptedData, length); 



  class AESEncriptBehavior : IEncryptBehavior
  {

    public byte[] Encript(byte[] dataToEncrypt, SuperClass.Encryption self)
    {

      byte[] encryptedData;

      //AesEngine engine = new AesEngine();
      //CbcBlockCipher blockCipher = new CbcBlockCipher(engine);
      //PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(blockCipher);
      //KeyParameter keyParam = new KeyParameter(self.SecretKey.Value);
      //ParametersWithIV keyParamWithIV = new ParametersWithIV(keyParam, self.UtilityKey.Value, 0, 16);

      using (AesCryptoServiceProvider provider = new AesCryptoServiceProvider())
      {
        provider.IV = self.UtilityKey.Value;
        provider.Key = self.SecretKey.Value;

        ICryptoTransform encryptor = provider.CreateEncryptor();
        encryptedData = EncryptionUtility.ExecuteProviderTransformation(encryptor, dataToEncrypt);
      }
      return encryptedData;
    }

    public byte[] Encript(byte[] dataToEncrypt, CipherMode cipherMode , PaddingMode paddingMode ,SuperClass.Encryption self)
    {

      byte[] encryptedData;
      using (AesCryptoServiceProvider provider = new AesCryptoServiceProvider())
      {
        provider.IV = self.UtilityKey.Value;
        provider.Key = self.SecretKey.Value;
        provider.Mode = cipherMode;
        provider.Padding = paddingMode;
        ICryptoTransform encryptor = provider.CreateEncryptor();
        encryptedData = EncryptionUtility.ExecuteProviderTransformation(encryptor, dataToEncrypt);
      }
      return encryptedData;
    }

  }
}
