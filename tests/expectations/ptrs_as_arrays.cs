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
  [DllImport("bindgen.dll")]
  public static extern void ptr_as_array(uint32_t n,
                                         [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
                                         uint32_t[] arg,
                                         ref uint64_t v);
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void ptr_as_array1(uint32_t n,
                                          [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
                                          uint32_t[] arg,
                                          [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
                                          uint64_t[] v);
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void ptr_as_array2(uint32_t n,
                                          [MarshalAs(UnmanagedType.ByValArray, SizeConst=)]
                                          uint32_t[] arg,
                                          [MarshalAs(UnmanagedType.ByValArray, SizeConst=)]
                                          uint64_t[] v);
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void ptr_as_array_wrong_syntax(ref uint32_t arg,
                                                      ref uint32_t v,
                                                      ref uint32_t _2);
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void ptr_as_array_unnamed(ref uint32_t _0, ref uint32_t _1);
}
