using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JGEncryption.Encryption.Interfaces
{
  interface IEncryption
  {
    ISecretKey SecretKey { get; set; }
    IUtilityKey UtilityKey { get; set; }
    byte[] GetSecretKey();
    byte[] GetUtilityKey();
    byte[] Encrypt(byte[] dataToEncrypt);
    byte[] Decrypt(byte[] dataToDecrypt);




  }
}
