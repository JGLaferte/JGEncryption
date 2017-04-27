using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JGEncryption.Encryption.Interfaces
{
  public interface IEncryptBehavior
  {
    byte[] Encript(byte[] dataToEncrypt, SuperClass.Encryption sef);
  }
}
