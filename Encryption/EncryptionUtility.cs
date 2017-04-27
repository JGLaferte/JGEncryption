using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JGEncryption.Encryption
{
  static class  EncryptionUtility
  {
    public static byte[] ExecuteProviderTransformation(ICryptoTransform transformer, byte[] dataToEncrypt)
    {
      byte[] EncryptedData;
      using (MemoryStream streamReader = new MemoryStream())
      {
        using (CryptoStream cryptoStream = new CryptoStream(streamReader, transformer, CryptoStreamMode.Write))
        {
          cryptoStream.Write(dataToEncrypt, 0, dataToEncrypt.Length);
        }
        EncryptedData = streamReader.ToArray();
      }
      return EncryptedData;
    }


  }
}
