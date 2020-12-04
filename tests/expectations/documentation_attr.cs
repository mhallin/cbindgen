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
  /*
  With doc attr, each attr contribute to one line of document
  like this one with a new line character at its end
  and this one as well. So they are in the same paragraph

  Line ends with one new line should not break

  Line ends with two spaces and a new line
  should break to next line

  Line ends with two new lines

  Should break to next paragraph
   */
  [DllImport("bindgen.dll")]
  public static extern void root();
}
