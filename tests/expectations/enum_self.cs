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

public struct Foo_Bar {
  public ref int32_t something;
};

public enum Bar_Tag: uint8_t {
  Min,
  Max,
  Other,
};

public struct Min_Body {
  public Bar_Tag tag;
  public Foo_Bar _0;
};

public struct Max_Body {
  public Bar_Tag tag;
  public Foo_Bar _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct Bar {
  [FieldOffset(0)] public Bar_Tag tag;
  [FieldOffset(0)] public Min_Body min;
  [FieldOffset(0)] public Max_Body max;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(Bar b);
}
