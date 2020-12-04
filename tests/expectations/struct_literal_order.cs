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

public struct ABC {
  public float a;
  public uint32_t b;
  public uint32_t c;
};
public partial class Functions {
  public static readonly ABC ABC_abc = new ABC {  a = 1.0f,  b = 2,  c = 3 };
}
public partial class Functions {
  public static readonly ABC ABC_bac = new ABC {  a = 1.0f,  b = 2,  c = 3 };
}
public partial class Functions {
  public static readonly ABC ABC_cba = new ABC {  a = 1.0f,  b = 2,  c = 3 };
}

public struct BAC {
  public uint32_t b;
  public float a;
  public int32_t c;
};
public partial class Functions {
  public static readonly BAC BAC_abc = new BAC {  b = 1,  a = 2.0f,  c = 3 };
}
public partial class Functions {
  public static readonly BAC BAC_bac = new BAC {  b = 1,  a = 2.0f,  c = 3 };
}
public partial class Functions {
  public static readonly BAC BAC_cba = new BAC {  b = 1,  a = 2.0f,  c = 3 };
}

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(ABC a1, BAC a2);
}
