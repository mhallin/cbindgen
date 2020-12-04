#if 0
DEF FOO = 0
DEF BAR = 0
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

#if defined(FOO)
public partial class Library {
  public const int32_t FOO = 1;
}
#endif

#if defined(BAR)
public partial class Library {
  public const int32_t BAR = 2;
}
#endif

#if defined(FOO)
public struct Foo {

};
#endif

#if defined(BAR)
public struct Bar {

};
#endif

public partial class Library {
#if defined(FOO)
  [DllImport("bindgen.dll")]
  public static extern void foo(ref Foo foo);
#endif
}

public partial class Library {
#if defined(BAR)
  [DllImport("bindgen.dll")]
  public static extern void bar(ref Bar bar);
#endif
}
