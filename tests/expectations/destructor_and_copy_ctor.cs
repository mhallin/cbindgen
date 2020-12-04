#define NOINLINE __attribute__((noinline))
#define NODISCARD [[nodiscard]]


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

public enum FillRule: uint8_t {
  A,
  B,
};

/*
 This will have a destructor manually implemented via variant_body, and
 similarly a Drop impl in Rust.
 */
public struct OwnedSlice_u32 {
  public uintptr_t len;
  public ref uint32_t ptr;
};

public struct Polygon_u32 {
  public FillRule fill;
  public OwnedSlice_u32 coordinates;
};

/*
 This will have a destructor manually implemented via variant_body, and
 similarly a Drop impl in Rust.
 */
public struct OwnedSlice_i32 {
  public uintptr_t len;
  public ref int32_t ptr;
};

public enum Foo_u32_Tag: uint8_t {
  Bar_u32,
  Polygon1_u32,
  Slice1_u32,
  Slice2_u32,
  Slice3_u32,
  Slice4_u32,
};

public struct Polygon1_Body_u32 {
  public Polygon_u32 _0;
};

public struct Slice1_Body_u32 {
  public OwnedSlice_u32 _0;
};

public struct Slice2_Body_u32 {
  public OwnedSlice_i32 _0;
};

public struct Slice3_Body_u32 {
  public FillRule fill;
  public OwnedSlice_u32 coords;
};

public struct Slice4_Body_u32 {
  public FillRule fill;
  public OwnedSlice_i32 coords;
};

[StructLayout(LayoutKind.Explicit)]
public struct Foo_u32 {
  [FieldOffset(0)] public Foo_u32_Tag tag;
  [FieldOffset(0)] public Polygon1_Body_u32 polygon1;
  [FieldOffset(0)] public Slice1_Body_u32 slice1;
  [FieldOffset(0)] public Slice2_Body_u32 slice2;
  [FieldOffset(0)] public Slice3_Body_u32 slice3;
  [FieldOffset(0)] public Slice4_Body_u32 slice4;
};

public struct Polygon_i32 {
  public FillRule fill;
  public OwnedSlice_i32 coordinates;
};

public enum Baz_i32_Tag: uint8_t {
  Bar2_i32,
  Polygon21_i32,
  Slice21_i32,
  Slice22_i32,
  Slice23_i32,
  Slice24_i32,
};

public struct Polygon21_Body_i32 {
  public Baz_i32_Tag tag;
  public Polygon_i32 _0;
};

public struct Slice21_Body_i32 {
  public Baz_i32_Tag tag;
  public OwnedSlice_i32 _0;
};

public struct Slice22_Body_i32 {
  public Baz_i32_Tag tag;
  public OwnedSlice_i32 _0;
};

public struct Slice23_Body_i32 {
  public Baz_i32_Tag tag;
  public FillRule fill;
  public OwnedSlice_i32 coords;
};

public struct Slice24_Body_i32 {
  public Baz_i32_Tag tag;
  public FillRule fill;
  public OwnedSlice_i32 coords;
};

[StructLayout(LayoutKind.Explicit)]
public struct Baz_i32 {
  [FieldOffset(0)] public Baz_i32_Tag tag;
  [FieldOffset(0)] public Polygon21_Body_i32 polygon21;
  [FieldOffset(0)] public Slice21_Body_i32 slice21;
  [FieldOffset(0)] public Slice22_Body_i32 slice22;
  [FieldOffset(0)] public Slice23_Body_i32 slice23;
  [FieldOffset(0)] public Slice24_Body_i32 slice24;
};

public enum Taz_Tag: uint8_t {
  Bar3,
  Taz1,
  Taz3,
};

public struct Taz1_Body {
  public Taz_Tag tag;
  public int32_t _0;
};

public struct Taz3_Body {
  public Taz_Tag tag;
  public OwnedSlice_i32 _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct Taz {
  [FieldOffset(0)] public Taz_Tag tag;
  [FieldOffset(0)] public Taz1_Body taz1;
  [FieldOffset(0)] public Taz3_Body taz3;
};

public enum Tazz_Tag: uint8_t {
  Bar4,
  Taz2,
};

public struct Taz2_Body {
  public Tazz_Tag tag;
  public int32_t _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct Tazz {
  [FieldOffset(0)] public Tazz_Tag tag;
  [FieldOffset(0)] public Taz2_Body taz2;
};

public enum Tazzz_Tag: uint8_t {
  Bar5,
  Taz5,
};

public struct Taz5_Body {
  public Tazzz_Tag tag;
  public int32_t _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct Tazzz {
  [FieldOffset(0)] public Tazzz_Tag tag;
  [FieldOffset(0)] public Taz5_Body taz5;
};

public enum Tazzzz_Tag: uint8_t {
  Taz6,
  Taz7,
};

public struct Taz6_Body {
  public Tazzzz_Tag tag;
  public int32_t _0;
};

public struct Taz7_Body {
  public Tazzzz_Tag tag;
  public uint32_t _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct Tazzzz {
  [FieldOffset(0)] public Tazzzz_Tag tag;
  [FieldOffset(0)] public Taz6_Body taz6;
  [FieldOffset(0)] public Taz7_Body taz7;
};

public enum Qux_Tag: uint8_t {
  Qux1,
  Qux2,
};

public struct Qux1_Body {
  public Qux_Tag tag;
  public int32_t _0;
};

public struct Qux2_Body {
  public Qux_Tag tag;
  public uint32_t _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct Qux {
  [FieldOffset(0)] public Qux_Tag tag;
  [FieldOffset(0)] public Qux1_Body qux1;
  [FieldOffset(0)] public Qux2_Body qux2;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(ref Foo_u32 a,
                                 ref Baz_i32 b,
                                 ref Taz c,
                                 Tazz d,
                                 ref Tazzz e,
                                 ref Tazzzz f,
                                 ref Qux g);
}
