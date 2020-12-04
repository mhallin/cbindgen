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
  public const int32_t PREFIX_LEN = 22;
}

public partial class Functions {
  public const int64_t PREFIX_X = (22 << 22);
}

public partial class Functions {
  public const int64_t PREFIX_Y = (PREFIX_X + PREFIX_X);
}

using PREFIX_NamedLenArray = int32_t[PREFIX_LEN];

using PREFIX_ValuedLenArray = int32_t[22];

public enum PREFIX_AbsoluteFontWeight_Tag: uint8_t {
  Weight,
  Normal,
  Bold,
};

public struct PREFIX_Weight_Body {
  public PREFIX_AbsoluteFontWeight_Tag tag;
  public float _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct PREFIX_AbsoluteFontWeight {
  [FieldOffset(0)] public PREFIX_AbsoluteFontWeight_Tag tag;
  [FieldOffset(0)] public PREFIX_Weight_Body weight;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(PREFIX_NamedLenArray x,
                                 PREFIX_ValuedLenArray y,
                                 PREFIX_AbsoluteFontWeight z);
}
