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

public partial class Functions {
  public const int64_t CONSTANT_I64 = 216;
}

public partial class Functions {
  public const float CONSTANT_FLOAT32 = 312.292f;
}

public partial class Functions {
  public const uint32_t DELIMITER = ':';
}

public partial class Functions {
  public const uint32_t LEFTCURLY = '{';
}

public struct Foo {
  public int32_t x;
};
public partial class Functions {
  public const int64_t Foo_CONSTANT_I64_BODY = 216;
}

public partial class Functions {
  public static readonly Foo SomeFoo = new Foo {  x = 99 };
}
