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

public struct NotReprC_RefCell_i32 {
  IntPtr _opaque;
}

using Foo = NotReprC_RefCell_i32;

public struct MyStruct {
  public int32_t number;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(ref Foo a, ref MyStruct with_cell);
}
