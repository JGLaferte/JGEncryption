﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JGEncryption.Encryption.Interfaces
{
  public interface ISecretKey
  {
    byte[] Value { get; set; }
  }
}
