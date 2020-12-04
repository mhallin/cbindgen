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

public enum A: uint8_t {
  A_A1,
  A_A2,
  A_A3,
  /*
   Must be last for serialization purposes
   */
  A_Sentinel,
};

public enum B: uint8_t {
  B_B1,
  B_B2,
  B_B3,
  /*
   Must be last for serialization purposes
   */
  B_Sentinel,
};

public enum C_Tag: uint8_t {
  C_C1,
  C_C2,
  C_C3,
  /*
   Must be last for serialization purposes
   */
  C_Sentinel,
};

public struct C_C1_Body {
  public C_Tag tag;
  public uint32_t a;
};

public struct C_C2_Body {
  public C_Tag tag;
  public uint32_t b;
};

[StructLayout(LayoutKind.Explicit)]
public struct C {
  [FieldOffset(0)] public C_Tag tag;
  [FieldOffset(0)] public C_C1_Body c1;
  [FieldOffset(0)] public C_C2_Body c2;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(A a, B b, C c);
}
