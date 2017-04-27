using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;

namespace JGEncryption.Encryption.Utilities
{
  internal class Check
  {
    internal static void DataLength(bool condition, string msg)
    {
      if (condition)
        throw new DataLengthException(msg);
    }

    internal static void DataLength(byte[] buf, int off, int len, string msg)
    {
      if (off + len > buf.Length)
        throw new DataLengthException(msg);
    }

    internal static void OutputLength(byte[] buf, int off, int len, string msg)
    {
      if (off + len > buf.Length)
        throw new OutputLengthException(msg);
    }
  }
}
