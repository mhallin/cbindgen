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

public enum Status: uint32_t {
  Ok,
  Err,
};

public struct Dep {
  public int32_t a;
  public float b;
};

public struct Foo_i32 {
  public int32_t a;
  public int32_t b;
  public Dep c;
};

using IntFoo = Foo_i32;

public struct Foo_f64 {
  public double a;
  public double b;
  public Dep c;
};

using DoubleFoo = Foo_f64;

using Unit = int32_t;

using SpecialStatus = Status;

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(IntFoo x, DoubleFoo y, Unit z, SpecialStatus w);
}
