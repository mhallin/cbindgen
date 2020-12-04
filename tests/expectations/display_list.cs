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

public struct Rect {
  public float x;
  public float y;
  public float w;
  public float h;
};

public struct Color {
  public uint8_t r;
  public uint8_t g;
  public uint8_t b;
  public uint8_t a;
};

public enum DisplayItem_Tag: uint8_t {
  Fill,
  Image,
  ClearScreen,
};

public struct Fill_Body {
  public DisplayItem_Tag tag;
  public Rect _0;
  public Color _1;
};

public struct Image_Body {
  public DisplayItem_Tag tag;
  public uint32_t id;
  public Rect bounds;
};

[StructLayout(LayoutKind.Explicit)]
public struct DisplayItem {
  [FieldOffset(0)] public DisplayItem_Tag tag;
  [FieldOffset(0)] public Fill_Body fill;
  [FieldOffset(0)] public Image_Body image;
};

public partial class Library {
  [DllImport("bindgen.dll")]
  public static extern bool push_item(DisplayItem item);
}
