#define CF_SWIFT_NAME(_name) __attribute__((swift_name(#_name)))

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

public struct Opaque {
  IntPtr _opaque;
}

public struct SelfTypeTestStruct {
  public uint8_t times;
};

public struct PointerToOpaque {
  public ref Opaque ptr;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void rust_print_hello_world() CF_SWIFT_NAME(rust_print_hello_world());
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_exist_ref(ref SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_exist_ref(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_exist_ref_mut(ref SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_exist_ref_mut(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_not_exist_box(ref SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_not_exist_box(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern ref SelfTypeTestStruct SelfTypeTestStruct_should_not_exist_return_box() CF_SWIFT_NAME(SelfTypeTestStruct.should_not_exist_return_box());
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_exist_annotated_self(SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_exist_annotated_self(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_exist_annotated_mut_self(SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_exist_annotated_mut_self(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_exist_annotated_by_name(SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_exist_annotated_by_name(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_exist_annotated_mut_by_name(SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_exist_annotated_mut_by_name(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_exist_unannotated(SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_exist_unannotated(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void SelfTypeTestStruct_should_exist_mut_unannotated(SelfTypeTestStruct self) CF_SWIFT_NAME(SelfTypeTestStruct.should_exist_mut_unannotated(self:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void free_function_should_exist_ref(ref SelfTypeTestStruct test_struct) CF_SWIFT_NAME(free_function_should_exist_ref(test_struct:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void free_function_should_exist_ref_mut(ref SelfTypeTestStruct test_struct) CF_SWIFT_NAME(free_function_should_exist_ref_mut(test_struct:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void unnamed_argument(ref SelfTypeTestStruct _0);
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void free_function_should_not_exist_box(ref SelfTypeTestStruct boxed) CF_SWIFT_NAME(free_function_should_not_exist_box(boxed:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void free_function_should_exist_annotated_by_name(SelfTypeTestStruct test_struct) CF_SWIFT_NAME(free_function_should_exist_annotated_by_name(test_struct:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void free_function_should_exist_annotated_mut_by_name(SelfTypeTestStruct test_struct) CF_SWIFT_NAME(free_function_should_exist_annotated_mut_by_name(test_struct:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern PointerToOpaque PointerToOpaque_create(uint8_t times) CF_SWIFT_NAME(PointerToOpaque.create(times:));
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void PointerToOpaque_sayHello(PointerToOpaque self) CF_SWIFT_NAME(PointerToOpaque.sayHello(self:));
}
