using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using JGEncryption.Encryption.Interfaces;

namespace JGEncryption.Encryption.Biaviors
{
  class AESDecryptorBehavior : IDecryptBehavior
  {
    public byte[] Decrypt(byte[] dataToDecrypt, SuperClass.Encryption self)
    {
      byte[] DecryptedData;
      using (AesCryptoServiceProvider provider = new AesCryptoServiceProvider())
      {
        provider.Key = self.GetSecretKey();
        provider.IV = self.GetUtilityKey();
        ICryptoTransform transformer = provider.CreateDecryptor();
        DecryptedData = EncryptionUtility.ExecuteProviderTransformation(transformer, dataToDecrypt);

      }
      return DecryptedData;
    }
  }
}
