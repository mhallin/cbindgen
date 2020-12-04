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

public enum A: uint64_t {
  a1 = 0,
  a2 = 2,
  a3,
  a4 = 5,
};

public enum B: uint32_t {
  b1 = 0,
  b2 = 2,
  b3,
  b4 = 5,
};

public enum C: uint16_t {
  c1 = 0,
  c2 = 2,
  c3,
  c4 = 5,
};

public enum D: uint8_t {
  d1 = 0,
  d2 = 2,
  d3,
  d4 = 5,
};

public enum E {
  e1 = 0,
  e2 = 2,
  e3,
  e4 = 5,
};

public enum F {
  f1 = 0,
  f2 = 2,
  f3,
  f4 = 5,
};

public enum L {
  l1,
  l2,
  l3,
  l4,
};

public enum M: int8_t {
  m1 = -1,
  m2 = 0,
  m3 = 1,
};

public enum N {
  n1,
  n2,
  n3,
  n4,
};

public enum O: int8_t {
  o1,
  o2,
  o3,
  o4,
};

public struct J {
  IntPtr _opaque;
}

public struct K {
  IntPtr _opaque;
}

public struct Opaque {
  IntPtr _opaque;
}

public enum G_Tag: uint8_t {
  Foo,
  Bar,
  Baz,
};

public struct Foo_Body {
  public G_Tag tag;
  public int16_t _0;
};

public struct Bar_Body {
  public G_Tag tag;
  public uint8_t x;
  public int16_t y;
};

[StructLayout(LayoutKind.Explicit)]
public struct G {
  [FieldOffset(0)] public G_Tag tag;
  [FieldOffset(0)] public Foo_Body foo;
  [FieldOffset(0)] public Bar_Body bar;
};

public enum H_Tag {
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

public enum I_Tag: uint8_t {
  I_Foo,
  I_Bar,
  I_Baz,
};

public struct I_Foo_Body {
  public int16_t _0;
};

public struct I_Bar_Body {
  public uint8_t x;
  public int16_t y;
};

[StructLayout(LayoutKind.Explicit)]
public struct I {
  [FieldOffset(0)] public I_Tag tag;
  [FieldOffset(0)] public I_Foo_Body foo;
  [FieldOffset(0)] public I_Bar_Body bar;
};

public enum P_Tag: uint8_t {
  P0,
  P1,
};

public struct P0_Body {
  public uint8_t _0;
};

public struct P1_Body {
  public uint8_t _0;
  public uint8_t _1;
  public uint8_t _2;
};

[StructLayout(LayoutKind.Explicit)]
public struct P {
  [FieldOffset(0)] public P_Tag tag;
  [FieldOffset(0)] public P0_Body p0;
  [FieldOffset(0)] public P1_Body p1;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(ref Opaque opaque,
                                 A a,
                                 B b,
                                 C c,
                                 D d,
                                 E e,
                                 F f,
                                 G g,
                                 H h,
                                 I i,
                                 J j,
                                 K k,
                                 L l,
                                 M m,
                                 N n,
                                 O o,
                                 P p);
}


