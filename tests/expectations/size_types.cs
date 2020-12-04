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

public enum IE: ptrdiff_t {
  IV,
};

public enum UE: size_t {
  UV,
};

using Usize = size_t;

using Isize = ptrdiff_t;

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(Usize _0, Isize _1, UE _2, IE _3);
}
