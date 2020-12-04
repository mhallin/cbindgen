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

public struct Opaque {
  IntPtr _opaque;
}

public struct Foo_u64 {
  public ref float a;
  public ref uint64_t b;
  public ref Opaque c;
  public ref ref uint64_t d;
  public ref ref float e;
  public ref ref Opaque f;
  public ref uint64_t g;
  public ref int32_t h;
  public ref ref int32_t i;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(ref int32_t arg, ref Foo_u64 foo, ref ref Opaque d);
}
