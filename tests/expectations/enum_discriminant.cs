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

public partial class Library {
  public const int8_t FOUR = 4;
}

public enum E: int8_t {
  A = 1,
  B = -1,
  C = (1 + 2),
  D = FOUR,
  F = 5,
  G = (int8_t)54,
  H = (int8_t)false,
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(ref E _0);
}
