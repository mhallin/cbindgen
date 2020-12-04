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

public struct TypedLength_f32__UnknownUnit {
  public float _0;
};

public struct TypedLength_f32__LayoutUnit {
  public float _0;
};

using Length_f32 = TypedLength_f32__UnknownUnit;

using LayoutLength = TypedLength_f32__LayoutUnit;

public struct TypedSideOffsets2D_f32__UnknownUnit {
  public float top;
  public float right;
  public float bottom;
  public float left;
};

public struct TypedSideOffsets2D_f32__LayoutUnit {
  public float top;
  public float right;
  public float bottom;
  public float left;
};

using SideOffsets2D_f32 = TypedSideOffsets2D_f32__UnknownUnit;

using LayoutSideOffsets2D = TypedSideOffsets2D_f32__LayoutUnit;

public struct TypedSize2D_f32__UnknownUnit {
  public float width;
  public float height;
};

public struct TypedSize2D_f32__LayoutUnit {
  public float width;
  public float height;
};

using Size2D_f32 = TypedSize2D_f32__UnknownUnit;

using LayoutSize2D = TypedSize2D_f32__LayoutUnit;

public struct TypedPoint2D_f32__UnknownUnit {
  public float x;
  public float y;
};

public struct TypedPoint2D_f32__LayoutUnit {
  public float x;
  public float y;
};

using Point2D_f32 = TypedPoint2D_f32__UnknownUnit;

using LayoutPoint2D = TypedPoint2D_f32__LayoutUnit;

public struct TypedRect_f32__UnknownUnit {
  public TypedPoint2D_f32__UnknownUnit origin;
  public TypedSize2D_f32__UnknownUnit size;
};

public struct TypedRect_f32__LayoutUnit {
  public TypedPoint2D_f32__LayoutUnit origin;
  public TypedSize2D_f32__LayoutUnit size;
};

using Rect_f32 = TypedRect_f32__UnknownUnit;

using LayoutRect = TypedRect_f32__LayoutUnit;

public struct TypedTransform2D_f32__UnknownUnit__LayoutUnit {
  public float m11;
  public float m12;
  public float m21;
  public float m22;
  public float m31;
  public float m32;
};

public struct TypedTransform2D_f32__LayoutUnit__UnknownUnit {
  public float m11;
  public float m12;
  public float m21;
  public float m22;
  public float m31;
  public float m32;
};

public partial class Functions {
  [DllImport("bindgen.dll")]
  public static extern void root(TypedLength_f32__UnknownUnit length_a,
                                 TypedLength_f32__LayoutUnit length_b,
                                 Length_f32 length_c,
                                 LayoutLength length_d,
                                 TypedSideOffsets2D_f32__UnknownUnit side_offsets_a,
                                 TypedSideOffsets2D_f32__LayoutUnit side_offsets_b,
                                 SideOffsets2D_f32 side_offsets_c,
                                 LayoutSideOffsets2D side_offsets_d,
                                 TypedSize2D_f32__UnknownUnit size_a,
                                 TypedSize2D_f32__LayoutUnit size_b,
                                 Size2D_f32 size_c,
                                 LayoutSize2D size_d,
                                 TypedPoint2D_f32__UnknownUnit point_a,
                                 TypedPoint2D_f32__LayoutUnit point_b,
                                 Point2D_f32 point_c,
                                 LayoutPoint2D point_d,
                                 TypedRect_f32__UnknownUnit rect_a,
                                 TypedRect_f32__LayoutUnit rect_b,
                                 Rect_f32 rect_c,
                                 LayoutRect rect_d,
                                 TypedTransform2D_f32__UnknownUnit__LayoutUnit transform_a,
                                 TypedTransform2D_f32__LayoutUnit__UnknownUnit transform_b);
}
