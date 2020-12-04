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

public struct Foo {

};
public partial class Library {
  public const int32_t Foo_GA = 10;
}
public partial class Library {
  public const float Foo_ZO = 3.14f;
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(Foo x);
}
