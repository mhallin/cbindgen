#ifdef __clang__
#define CBINDGEN_NONNULL _Nonnull
#else
#define CBINDGEN_NONNULL
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

public struct Opaque {
  IntPtr _opaque;
}

public struct References {
  public ref Opaque CBINDGEN_NONNULL a;
  public ref Opaque CBINDGEN_NONNULL b;
  public ref Opaque c;
  public ref Opaque d;
};

public struct Pointers_u64 {
  public ref float CBINDGEN_NONNULL a;
  public ref uint64_t CBINDGEN_NONNULL b;
  public ref Opaque CBINDGEN_NONNULL c;
  public ref ref uint64_t CBINDGEN_NONNULL CBINDGEN_NONNULL d;
  public ref ref float CBINDGEN_NONNULL CBINDGEN_NONNULL e;
  public ref ref Opaque CBINDGEN_NONNULL CBINDGEN_NONNULL f;
  public ref uint64_t g;
  public ref int32_t h;
  public ref ref int32_t CBINDGEN_NONNULL i;
  public ref uint64_t j;
  public ref uint64_t k;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void value_arg(References arg);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void mutltiple_args(ref int32_t CBINDGEN_NONNULL arg,
                                           ref Pointers_u64 foo,
                                           ref ref Opaque CBINDGEN_NONNULL CBINDGEN_NONNULL d);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void ref_arg(ref Pointers_u64 CBINDGEN_NONNULL arg);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void mut_ref_arg(ref Pointers_u64 CBINDGEN_NONNULL arg);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void optional_ref_arg(ref Pointers_u64 arg);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void optional_mut_ref_arg(ref Pointers_u64 arg);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void nullable_const_ptr(ref Pointers_u64 arg);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void nullable_mut_ptr(ref Pointers_u64 arg);
}
