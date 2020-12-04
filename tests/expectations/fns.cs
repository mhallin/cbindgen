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

public struct Fns {
  public ref void (noArgs)();
  public ref void (anonymousArg)(int32_t _0);
  public ref int32_t (returnsNumber)();
  public ref int8_t (namedArgs)(int32_t first, int16_t snd);
  public ref int8_t (namedArgsWildcards)(int32_t _, int16_t named, int64_t _1);
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(Fns _fns);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void no_return();
}
