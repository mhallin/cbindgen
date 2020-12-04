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

namespace constants {
  namespace test {

    public partial class Library {
      public const int32_t FOO = 10;
    }

    public partial class Library {
      public const float ZOM = 3.14f;
    }

    public struct Foo {
      [MarshalAs(UnmanagedType.ByValArray, SizeConst=FOO)]
      public int32_t[] x;
    };

    public partial class Library {
      [DllImport("bindgen.dll")]
      public static extern void root(Foo x);
    }

    } // namespace test
  } // namespace constants
