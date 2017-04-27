using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JGEncryption.Encryption.Interfaces
{
  public interface IDecryptBehavior
  {
    byte[] Decrypt(byte[] dataToDecrypt, SuperClass.Encryption sef);
  }
}
