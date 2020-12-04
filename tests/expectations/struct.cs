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

public struct Opaque {
  IntPtr _opaque;
}

public struct Normal {
  public int32_t x;
  public float y;
};

public struct NormalWithZST {
  public int32_t x;
  public float y;
};

public struct TupleRenamed {
  public int32_t m0;
  public float m1;
};

public struct TupleNamed {
  public int32_t x;
  public float y;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(ref Opaque a,
                                 Normal b,
                                 NormalWithZST c,
                                 TupleRenamed d,
                                 TupleNamed e);
}
