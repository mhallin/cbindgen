#define MUST_USE_FUNC __attribute__((warn_unused_result))
#define MUST_USE_STRUCT __attribute__((warn_unused))
#define MUST_USE_ENUM /* nothing */


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

public enum MaybeOwnedPtr_i32_Tag: uint8_t {
  Owned_i32,
  None_i32,
};

public struct Owned_Body_i32 {
  public ref int32_t _0;
};

[StructLayout(LayoutKind.Explicit)]
public struct MUST_USE_STRUCT MaybeOwnedPtr_i32 {
  [FieldOffset(0)] public MaybeOwnedPtr_i32_Tag tag;
  [FieldOffset(0)] public Owned_Body_i32 owned;
};

public struct MUST_USE_STRUCT OwnedPtr_i32 {
  public ref int32_t ptr;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern MaybeOwnedPtr_i32 maybe_consume(OwnedPtr_i32 input);
}
