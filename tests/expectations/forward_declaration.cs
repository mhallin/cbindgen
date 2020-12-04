#if 0
''' '
#endif
#if defined(CBINDGEN_STYLE_TYPE)
/* ANONYMOUS STRUCTS DO NOT SUPPORT FORWARD DECLARATIONS!
#endif
#if 0
' '''
#endif


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

public struct StructInfo {
  public ref ref TypeInfo fields;
  public uintptr_t num_fields;
};

public enum TypeData_Tag {
  Primitive,
  Struct,
};

public struct Struct_Body {
  public StructInfo _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct TypeData {
  [FieldOffset(0)] public TypeData_Tag tag;
  [FieldOffset(0)] public Struct_Body struct_;
};

public struct TypeInfo {
  public TypeData data;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(TypeInfo x);
}

#if 0
''' '
#endif
#if defined(CBINDGEN_STYLE_TYPE)
*/
#endif
#if 0
' '''
#endif
