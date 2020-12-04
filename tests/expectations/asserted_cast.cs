#define MY_ASSERT(...) do { } while (0)
#define MY_ATTRS __attribute((noinline))


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

public struct I {
  IntPtr _opaque;
}

public enum H_Tag: uint8_t {
  H_Foo,
  H_Bar,
  H_Baz,
};

public struct H_Foo_Body {
  public int16_t _0;
};

public struct H_Bar_Body {
  public uint8_t x;
  public int16_t y;
};

[StructLayout(LayoutKind.Explicit)]
public struct H {
  [FieldOffset(0)] public H_Tag tag;
  [FieldOffset(0)] public H_Foo_Body foo;
  [FieldOffset(0)] public H_Bar_Body bar;
};

public enum J_Tag: uint8_t {
  J_Foo,
  J_Bar,
  J_Baz,
};

public struct J_Foo_Body {
  public int16_t _0;
};

public struct J_Bar_Body {
  public uint8_t x;
  public int16_t y;
};

[StructLayout(LayoutKind.Explicit)]
public struct J {
  [FieldOffset(0)] public J_Tag tag;
  [FieldOffset(0)] public J_Foo_Body foo;
  [FieldOffset(0)] public J_Bar_Body bar;
};

public enum K_Tag: uint8_t {
  K_Foo,
  K_Bar,
  K_Baz,
};

public struct K_Foo_Body {
  public K_Tag tag;
  public int16_t _0;
};

public struct K_Bar_Body {
  public K_Tag tag;
  public uint8_t x;
  public int16_t y;
};

[StructLayout(LayoutKind.Explicit)]
public struct K {
  [FieldOffset(0)] public K_Tag tag;
  [FieldOffset(0)] public K_Foo_Body foo;
  [FieldOffset(0)] public K_Bar_Body bar;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void foo(H h, I i, J j, K k);
}
