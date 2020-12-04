#if 0
''' '
#endif

#ifdef __cplusplus
// These could be added as opaque types I guess.
template <typename T>
struct BuildHasherDefault;

struct DefaultHasher;
#endif

#if 0
' '''
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

public struct HashMap_i32__i32__BuildHasherDefault_DefaultHasher {
  IntPtr _opaque;
}

public struct Result_Foo {
  IntPtr _opaque;
}

/*
 Fast hash map used internally.
 */
using FastHashMap_i32__i32 = HashMap_i32__i32__BuildHasherDefault_DefaultHasher;

using Foo = FastHashMap_i32__i32;

using Bar = Result_Foo;

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(ref Foo a, ref Bar b);
}
