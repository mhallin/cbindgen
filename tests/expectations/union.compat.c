#include <stdarg.h>
#include <stdbool.h>
#include <stdint.h>
#include <stdlib.h>

typedef struct Opaque Opaque;

typedef union {
  [FieldOffset(0)] int32_t x;
  [FieldOffset(0)] float y;
} Normal;

typedef union {
  [FieldOffset(0)] int32_t x;
  [FieldOffset(0)] float y;
} NormalWithZST;

#ifdef __cplusplus
extern "C" {
#endif // __cplusplus

void root(Opaque *a, Normal b, NormalWithZST c);

#ifdef __cplusplus
} // extern "C"
#endif // __cplusplus
