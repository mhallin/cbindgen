using System;
using System.Runtime.InteropServices;
using uint8_t = System.Byte;
using int8_t = System.SByte;
using uint16_t = System.UInt16;
using int16_t = System.Int16;
using uint32_t = System.UInt32;
using int32_t = System.Int32;
using uint64_t = System.UInt64;
using int64_t = System.Int64;
using intptr_t = System.IntPtr;
using uintptr_t = System.UIntPtr;

public struct PREFIXBar {
  public int32_t a;
};

public struct PREFIXFoo {
  public int32_t a;
  public uint32_t b;
  public PREFIXBar bar;
};

public partial class Functions {
  public static readonly PREFIXFoo PREFIXVAL = new PREFIXFoo {  a = 42,  b = 1337,  bar = new PREFIXBar {  a = 323 } };
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(PREFIXFoo x);
}
