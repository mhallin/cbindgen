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

/*
 Constants shared by multiple CSS Box Alignment properties

 These constants match Gecko's `NS_STYLE_ALIGN_*` constants.
 */
public struct AlignFlags {
  public uint8_t bits;
};
/*
 'auto'
 */
public partial class Functions {
  public static readonly AlignFlags AlignFlags_AUTO = new AlignFlags {  bits = (uint8_t)0 };
}
/*
 'normal'
 */
public partial class Functions {
  public static readonly AlignFlags AlignFlags_NORMAL = new AlignFlags {  bits = (uint8_t)1 };
}
/*
 'start'
 */
public partial class Functions {
  public static readonly AlignFlags AlignFlags_START = new AlignFlags {  bits = (uint8_t)(1 << 1) };
}
/*
 'end'
 */
public partial class Functions {
  public static readonly AlignFlags AlignFlags_END = new AlignFlags {  bits = (uint8_t)(1 << 2) };
}
/*
 'flex-start'
 */
public partial class Functions {
  public static readonly AlignFlags AlignFlags_FLEX_START = new AlignFlags {  bits = (uint8_t)(1 << 3) };
}

public struct DebugFlags {
  public uint32_t bits;
};
/*
 Flag with the topmost bit set of the u32
 */
public partial class Functions {
  public static readonly DebugFlags DebugFlags_BIGGEST_ALLOWED = new DebugFlags {  bits = (uint32_t)(1 << 31) };
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(AlignFlags flags, DebugFlags bigger_flags);
}
