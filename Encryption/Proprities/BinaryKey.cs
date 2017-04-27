using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using JGEncryption.Encryption.Interfaces;

namespace JGEncryption.Encryption.Proprities
{
  public class BinaryKey : ISecretKey, IUtilityKey
  {
    public byte[] Value { get; set; }

    public BinaryKey(int bits)
    {
      System.Security.Cryptography.RandomNumberGenerator byteGenerator = new RNGCryptoServiceProvider();
      byte[] templateArray = new byte[bits / 8];
      byteGenerator.GetNonZeroBytes(templateArray);
      Value = templateArray;
    }

    public BinaryKey(byte[] key)
    {
      Value = key;
    }
  }
}
