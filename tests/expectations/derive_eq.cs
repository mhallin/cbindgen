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
  public bool a;
  public int32_t b;
};

public enum Bar_Tag: uint8_t {
  Baz,
  Bazz,
  FooNamed,
  FooParen,
};

public struct Bazz_Body {
  public Bar_Tag tag;
  public Foo named;
};

public struct FooNamed_Body {
  public Bar_Tag tag;
  public int32_t different;
  public uint32_t fields;
};

public struct FooParen_Body {
  public Bar_Tag tag;
  public int32_t _0;
  public Foo _1;
};

[StructLayout(LayoutKind.Explicit)]
public struct Bar {
  [FieldOffset(0)] public Bar_Tag tag;
  [FieldOffset(0)] public Bazz_Body bazz;
  [FieldOffset(0)] public FooNamed_Body foo_named;
  [FieldOffset(0)] public FooParen_Body foo_paren;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern Foo root(Bar aBar);
}
