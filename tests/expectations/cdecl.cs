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

using A = IntPtr()();

using B = IntPtr()();

using C = ref bool()(int32_t _0, int32_t _1);

using D = ref ref bool(()(int32_t _0))(float _0);

using E = [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
ref ref int32_t[](()());

using F = ref int32_t;

using G = ref ref int32_t;

using H = ref ref int32_t;

using I = [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
ref int32_t[]();

using J = ref ref double()(float _0);

using K = [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
int32_t[];

using L = [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
ref int32_t[];

using M = [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
ref bool[]()(int32_t _0, int32_t _1);

using N = [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
IntPtr()(int32_t _0, int32_t _1);

using P = IntPtr()(int32_t named1st, bool _1, bool named3rd, int32_t _);

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern IntPtr (O())();
}

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern void root(A a,
                                 B b,
                                 C c,
                                 D d,
                                 E e,
                                 F f,
                                 G g,
                                 H h,
                                 I i,
                                 J j,
                                 K k,
                                 L l,
                                 M m,
                                 N n,
                                 P p);
}
