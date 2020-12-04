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

public enum Foo_Tag {
  A,
};

public struct A_Body {
  public float _0[20];
};

[StructLayout(LayoutKind.Explicit)]
public struct Foo {
  [FieldOffset(0)] public Foo_Tag tag;
  [FieldOffset(0)] public A_Body a;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(Foo a);
}
