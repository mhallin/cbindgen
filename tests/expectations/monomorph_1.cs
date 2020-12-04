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

public struct Bar_Bar_f32 {
  IntPtr _opaque;
}

public struct Bar_Foo_f32 {
  IntPtr _opaque;
}

public struct Bar_f32 {
  IntPtr _opaque;
}

public struct Foo_i32 {
  public ref int32_t data;
};

public struct Foo_f32 {
  public ref float data;
};

public struct Foo_Bar_f32 {
  public ref Bar_f32 data;
};

public struct Tuple_Foo_f32_____f32 {
  public ref Foo_f32 a;
  public ref float b;
};

public struct Tuple_f32__f32 {
  public ref float a;
  public ref float b;
};

using Indirection_f32 = Tuple_f32__f32;

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(Foo_i32 a,
                                 Foo_f32 b,
                                 Bar_f32 c,
                                 Foo_Bar_f32 d,
                                 Bar_Foo_f32 e,
                                 Bar_Bar_f32 f,
                                 Tuple_Foo_f32_____f32 g,
                                 Indirection_f32 h);
}
