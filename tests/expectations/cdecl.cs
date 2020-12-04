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

using A = ref void()();

using B = ref void()();

using C = ref bool()(int32_t _0, int32_t _1);

using D = ref ref bool(()(int32_t _0))(float _0);

using E = ref ref int32_t(()())[16];

using F = ref int32_t;

using G = ref ref int32_t;

using H = ref ref int32_t;

using I = ref int32_t()[16];

using J = ref ref double()(float _0);

using K = int32_t[16];

using L = ref int32_t[16];

using M = ref bool([16])(int32_t _0, int32_t _1);

using N = ref void([16])(int32_t _0, int32_t _1);

using P = ref void()(int32_t named1st, bool _1, bool named3rd, int32_t _);

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern ref void (O())();
}

public partial class Functions {
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
