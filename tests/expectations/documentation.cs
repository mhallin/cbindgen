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

public partial class Library {
  /*
   The root of all evil.

   But at least it contains some more documentation as someone would expect
   from a simple test case like this.

   # Hint

   Always ensure that everything is properly documented, even if you feel lazy.
   **Sometimes** it is also helpful to include some markdown formatting.

   ////////////////////////////////////////////////////////////////////////////

   Attention:

      Rust is going to trim all leading `/` symbols. If you want to use them as a
      marker you need to add at least a single whitespace inbetween the tripple
      slash doc-comment marker and the rest.

   */
  [DllImport("bindgen.dll")]
  public static extern void root();
}
