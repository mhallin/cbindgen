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

public struct A {
  public ref int32_t data;
};

public enum E_Tag {
  V,
  U,
};

public struct U_Body {
  public ref uint8_t _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct E {
  [FieldOffset(0)] public E_Tag tag;
  [FieldOffset(0)] public U_Body u;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(A _a, E _e);
}
