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

public struct Option_i32 {
  IntPtr _opaque;
}

public struct Result_i32__String {
  IntPtr _opaque;
}

public struct Vec_String {
  IntPtr _opaque;
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(ref Vec_String a, ref Option_i32 b, ref Result_i32__String c);
}
