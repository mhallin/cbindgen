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
  public const uint8_t EXPORT_ME_TOO = 42;
}

public struct ExportMe {
  public uint64_t val;
};

public struct ExportMe2 {
  public uint64_t val;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void export_me(ref ExportMe val);
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void export_me_2(ref ExportMe2 _0);
}
