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

public partial class Library {
  public const uint64_t UNSIGNED_NEEDS_ULL_SUFFIX = 9223372036854775808ULL;
}

public partial class Library {
  public const uint64_t UNSIGNED_DOESNT_NEED_ULL_SUFFIX = 8070450532247928832;
}

public partial class Library {
  public const int64_t SIGNED_NEEDS_ULL_SUFFIX = -9223372036854775808ULL;
}

public partial class Library {
  public const int64_t SIGNED_DOESNT_NEED_ULL_SUFFIX = -9223372036854775807;
}
