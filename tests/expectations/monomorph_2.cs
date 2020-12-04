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

public struct A {
  IntPtr _opaque;
}

public struct B {
  IntPtr _opaque;
}

public struct List_A {
  public ref A members;
  public uintptr_t count;
};

public struct List_B {
  public ref B members;
  public uintptr_t count;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void foo(List_A a);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void bar(List_B b);
}
