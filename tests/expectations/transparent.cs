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

public struct DummyStruct {
  IntPtr _opaque;
}

public struct EnumWithAssociatedConstantInImpl {
  IntPtr _opaque;
}

using TransparentComplexWrappingStructTuple = DummyStruct;

using TransparentPrimitiveWrappingStructTuple = uint32_t;

using TransparentComplexWrappingStructure = DummyStruct;

using TransparentPrimitiveWrappingStructure = uint32_t;

using TransparentComplexWrapper_i32 = DummyStruct;

using TransparentPrimitiveWrapper_i32 = uint32_t;

using TransparentPrimitiveWithAssociatedConstants = uint32_t;
public partial class Functions {
  public static readonly TransparentPrimitiveWithAssociatedConstants TransparentPrimitiveWithAssociatedConstants_ZERO = 0;
}
public partial class Functions {
  public static readonly TransparentPrimitiveWithAssociatedConstants TransparentPrimitiveWithAssociatedConstants_ONE = 1;
}

public partial class Functions {
  public static readonly TransparentPrimitiveWrappingStructure EnumWithAssociatedConstantInImpl_TEN = 10;
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(TransparentComplexWrappingStructTuple a,
                                 TransparentPrimitiveWrappingStructTuple b,
                                 TransparentComplexWrappingStructure c,
                                 TransparentPrimitiveWrappingStructure d,
                                 TransparentComplexWrapper_i32 e,
                                 TransparentPrimitiveWrapper_i32 f,
                                 TransparentPrimitiveWithAssociatedConstants g,
                                 EnumWithAssociatedConstantInImpl h);
}
