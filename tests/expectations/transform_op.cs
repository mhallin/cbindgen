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

public struct StylePoint_i32 {
  public int32_t x;
  public int32_t y;
};

public struct StylePoint_f32 {
  public float x;
  public float y;
};

public enum StyleFoo_i32_Tag: uint8_t {
  Foo_i32,
  Bar_i32,
  Baz_i32,
  Bazz_i32,
};

public struct StyleFoo_Body_i32 {
  public StyleFoo_i32_Tag tag;
  public int32_t x;
  public StylePoint_i32 y;
  public StylePoint_f32 z;
};

public struct StyleBar_Body_i32 {
  public StyleFoo_i32_Tag tag;
  public int32_t _0;
};

public struct StyleBaz_Body_i32 {
  public StyleFoo_i32_Tag tag;
  public StylePoint_i32 _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct StyleFoo_i32 {
  [FieldOffset(0)] public StyleFoo_i32_Tag tag;
  [FieldOffset(0)] public StyleFoo_Body_i32 foo;
  [FieldOffset(0)] public StyleBar_Body_i32 bar;
  [FieldOffset(0)] public StyleBaz_Body_i32 baz;
};

public enum StyleBar_i32_Tag {
  Bar1_i32,
  Bar2_i32,
  Bar3_i32,
  Bar4_i32,
};

public struct StyleBar1_Body_i32 {
  public int32_t x;
  public StylePoint_i32 y;
  public StylePoint_f32 z;
  public ref int32_t (u)(int32_t _0);
};

public struct StyleBar2_Body_i32 {
  public int32_t _0;
};

public struct StyleBar3_Body_i32 {
  public StylePoint_i32 _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct StyleBar_i32 {
  [FieldOffset(0)] public StyleBar_i32_Tag tag;
  [FieldOffset(0)] public StyleBar1_Body_i32 bar1;
  [FieldOffset(0)] public StyleBar2_Body_i32 bar2;
  [FieldOffset(0)] public StyleBar3_Body_i32 bar3;
};

public struct StylePoint_u32 {
  public uint32_t x;
  public uint32_t y;
};

public enum StyleBar_u32_Tag {
  Bar1_u32,
  Bar2_u32,
  Bar3_u32,
  Bar4_u32,
};

public struct StyleBar1_Body_u32 {
  public int32_t x;
  public StylePoint_u32 y;
  public StylePoint_f32 z;
  public ref int32_t (u)(int32_t _0);
};

public struct StyleBar2_Body_u32 {
  public uint32_t _0;
};

public struct StyleBar3_Body_u32 {
  public StylePoint_u32 _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct StyleBar_u32 {
  [FieldOffset(0)] public StyleBar_u32_Tag tag;
  [FieldOffset(0)] public StyleBar1_Body_u32 bar1;
  [FieldOffset(0)] public StyleBar2_Body_u32 bar2;
  [FieldOffset(0)] public StyleBar3_Body_u32 bar3;
};

public enum StyleBaz_Tag: uint8_t {
  Baz1,
  Baz2,
  Baz3,
};

public struct StyleBaz1_Body {
  public StyleBaz_Tag tag;
  public StyleBar_u32 _0;
};

public struct StyleBaz2_Body {
  public StyleBaz_Tag tag;
  public StylePoint_i32 _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct StyleBaz {
  [FieldOffset(0)] public StyleBaz_Tag tag;
  [FieldOffset(0)] public StyleBaz1_Body baz1;
  [FieldOffset(0)] public StyleBaz2_Body baz2;
};

public enum StyleTaz_Tag: uint8_t {
  Taz1,
  Taz2,
  Taz3,
};

public struct StyleTaz1_Body {
  public StyleBar_u32 _0;
};

public struct StyleTaz2_Body {
  public StyleBaz _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct StyleTaz {
  [FieldOffset(0)] public StyleTaz_Tag tag;
  [FieldOffset(0)] public StyleTaz1_Body taz1;
  [FieldOffset(0)] public StyleTaz2_Body taz2;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void foo(ref StyleFoo_i32 foo,
                                ref StyleBar_i32 bar,
                                ref StyleBaz baz,
                                ref StyleTaz taz);
}
