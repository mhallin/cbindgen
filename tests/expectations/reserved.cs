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
  public int32_t namespace_;
  public float float_;
};

public struct B {
  public int32_t namespace_;
  public float float_;
};

public enum C_Tag: uint8_t {
  D,
};

public struct D_Body {
  public int32_t namespace_;
  public float float_;
};

[StructLayout(LayoutKind.Explicit)]
public struct C {
  [FieldOffset(0)] public C_Tag tag;
  [FieldOffset(0)] public D_Body d;
};

public enum E_Tag: uint8_t {
  Double,
  Float,
};

public struct Double_Body {
  public double _0;
};

public struct Float_Body {
  public float _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct E {
  [FieldOffset(0)] public E_Tag tag;
  [FieldOffset(0)] public Double_Body double_;
  [FieldOffset(0)] public Float_Body float_;
};

public enum F_Tag: uint8_t {
  double_,
  float_,
};

public struct double_Body {
  public double _0;
};

public struct float_Body {
  public float _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct F {
  [FieldOffset(0)] public F_Tag tag;
  [FieldOffset(0)] public double_Body double_;
  [FieldOffset(0)] public float_Body float_;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(A a, B b, C c, E e, F f, int32_t namespace_, float float_);
}
