#if 0
DEF PLATFORM_UNIX = 0
DEF PLATFORM_WIN = 0
DEF X11 = 0
DEF M_32 = 0
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

#if (defined(PLATFORM_WIN) || defined(M_32))
public enum BarType: uint32_t {
  A,
  B,
  C,
};
#endif

#if (defined(PLATFORM_UNIX) && defined(X11))
public enum FooType: uint32_t {
  A,
  B,
  C,
};
#endif

#if (defined(PLATFORM_UNIX) && defined(X11))
public struct FooHandle {
  public FooType ty;
  public int32_t x;
  public float y;
};
#endif

public enum C_Tag: uint8_t {
  C1,
  C2,
#if defined(PLATFORM_WIN)
  C3,
#endif
#if defined(PLATFORM_UNIX)
  C5,
#endif
};

#if defined(PLATFORM_UNIX)
public struct C5_Body {
  public C_Tag tag;
  public int32_t int_;
};
#endif

[StructLayout(LayoutKind.Explicit)]
public struct C {
  [FieldOffset(0)] public C_Tag tag;
#if defined(PLATFORM_UNIX)
  [FieldOffset(0)] public C5_Body c5;
#endif
};

#if (defined(PLATFORM_WIN) || defined(M_32))
public struct BarHandle {
  public BarType ty;
  public int32_t x;
  public float y;
};
#endif

public partial class Library {
#if (defined(PLATFORM_UNIX) && defined(X11))
  [DllImport("bindgen.dll")]
  public static extern void root(FooHandle a, C c);
#endif
}

public partial class Library {
#if (defined(PLATFORM_WIN) || defined(M_32))
  [DllImport("bindgen.dll")]
  public static extern void root(BarHandle a, C c);
#endif
}
