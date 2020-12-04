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

public enum C: uint32_t {
  X = 2,
  Y,
};

public struct A {
  public int32_t m0;
};

public struct B {
  public int32_t x;
  public float y;
};

public enum F_Tag: uint8_t {
  Foo,
  Bar,
  Baz,
};

public struct Foo_Body {
  public F_Tag tag;
  public int16_t _0;
};

public struct Bar_Body {
  public F_Tag tag;
  public uint8_t x;
  public int16_t y;
};

[StructLayout(LayoutKind.Explicit)]
public struct F {
  [FieldOffset(0)] public F_Tag tag;
  [FieldOffset(0)] public Foo_Body foo;
  [FieldOffset(0)] public Bar_Body bar;
};

public enum H_Tag: uint8_t {
  Hello,
  There,
  Everyone,
};

public struct Hello_Body {
  public int16_t _0;
};

public struct There_Body {
  public uint8_t x;
  public int16_t y;
};

[StructLayout(LayoutKind.Explicit)]
public struct H {
  [FieldOffset(0)] public H_Tag tag;
  [FieldOffset(0)] public Hello_Body hello;
  [FieldOffset(0)] public There_Body there;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(A x, B y, C z, F f, H h);
}
