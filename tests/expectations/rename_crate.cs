#if 0
DEF DEFINE_FREEBSD = 0
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

public struct Foo {
  public int32_t x;
};

public struct RenamedTy {
  public uint64_t y;
};

#if !defined(DEFINE_FREEBSD)
public struct NoExternTy {
  public uint8_t field;
};
#endif

#if !defined(DEFINE_FREEBSD)
public struct ContainsNoExternTy {
  public NoExternTy field;
};
#endif

#if defined(DEFINE_FREEBSD)
public struct ContainsNoExternTy {
  public uint64_t field;
};
#endif

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(Foo a);
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void renamed_func(RenamedTy a);
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void no_extern_func(ContainsNoExternTy a);
}
