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
  public const int32_t FOO = 10;
}

public partial class Functions {
  public const uint32_t DELIMITER = ':';
}

public partial class Functions {
  public const uint32_t LEFTCURLY = '{';
}

public partial class Functions {
  public const uint32_t QUOTE = '\'';
}

public partial class Functions {
  public const uint32_t TAB = '\t';
}

public partial class Functions {
  public const uint32_t NEWLINE = '\n';
}

public partial class Functions {
  public const uint32_t HEART = U'\U00002764';
}

public partial class Functions {
  public const uint32_t EQUID = U'\U00010083';
}

public partial class Functions {
  public const float ZOM = 3.14f;
}

/*
 A single-line doc comment.
 */
public partial class Functions {
  public const int8_t POS_ONE = 1;
}

/*
 A
 multi-line
 doc
 comment.
 */
public partial class Functions {
  public const int8_t NEG_ONE = -1;
}

public partial class Functions {
  public const int64_t SHIFT = 3;
}

public partial class Functions {
  public const int64_t XBOOL = 1;
}

public partial class Functions {
  public const int64_t XFALSE = ((0 << SHIFT) | XBOOL);
}

public partial class Functions {
  public const int64_t XTRUE = (1 << (SHIFT | XBOOL));
}

public partial class Functions {
  public const uint8_t CAST = (uint8_t)'A';
}

public partial class Functions {
  public const uint32_t DOUBLE_CAST = (uint32_t)(float)1;
}

public struct Foo {
  public int32_t x[FOO];
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(Foo x);
}
