#if 0
DEF DEFINED = 1
DEF NOT_DEFINED = 0
#endif


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

#if defined(NOT_DEFINED)
public partial class Functions {
  public const int32_t DEFAULT_X = 8;
}
#endif

#if defined(DEFINED)
public partial class Functions {
  public const int32_t DEFAULT_X = 42;
}
#endif

#if (defined(NOT_DEFINED) || defined(DEFINED))
public struct Foo {
  public int32_t x;
};
#endif

#if defined(NOT_DEFINED)
public struct Bar {
  public Foo y;
};
#endif

#if defined(DEFINED)
public struct Bar {
  public Foo z;
};
#endif

public struct Root {
  public Bar w;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(Root a);
}
