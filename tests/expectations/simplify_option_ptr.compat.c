#include <stdarg.h>
#include <stdbool.h>
#include <stdint.h>
#include <stdlib.h>

typedef struct Opaque Opaque;

typedef struct {
  const Opaque *x;
  Opaque *y;
  void (*z)(void);
} Foo;

typedef union {
  [FieldOffset(0)] const Opaque *x;
  [FieldOffset(0)] Opaque *y;
  [FieldOffset(0)] void (*z)(void);
} Bar;

#ifdef __cplusplus
extern "C" {
#endif // __cplusplus

void root(const Opaque *a, Opaque *b, Foo c, Bar d);

#ifdef __cplusplus
} // extern "C"
#endif // __cplusplus
