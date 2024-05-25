#if 0
''' '
#endif

#ifdef __cplusplus
template <typename T>
using Box = T*;
#endif

#if 0
' '''
#endif


#include <stdarg.h>
#include <stdbool.h>
#include <stdint.h>
#include <stdlib.h>

enum A
#ifdef __cplusplus
  : uint64_t
#endif // __cplusplus
 {
  a1 = 0,
  a2 = 2,
  a3,
  a4 = 5,
};
#ifndef __cplusplus
typedef uint64_t A;
#endif // __cplusplus

enum B
#ifdef __cplusplus
  : uint32_t
#endif // __cplusplus
 {
  b1 = 0,
  b2 = 2,
  b3,
  b4 = 5,
};
#ifndef __cplusplus
typedef uint32_t B;
#endif // __cplusplus

enum C
#ifdef __cplusplus
  : uint16_t
#endif // __cplusplus
 {
  c1 = 0,
  c2 = 2,
  c3,
  c4 = 5,
};
#ifndef __cplusplus
typedef uint16_t C;
#endif // __cplusplus

enum D
#ifdef __cplusplus
  : uint8_t
#endif // __cplusplus
 {
  d1 = 0,
  d2 = 2,
  d3,
  d4 = 5,
};
#ifndef __cplusplus
typedef uint8_t D;
#endif // __cplusplus

enum E
#ifdef __cplusplus
  : uintptr_t
#endif // __cplusplus
 {
  e1 = 0,
  e2 = 2,
  e3,
  e4 = 5,
};
#ifndef __cplusplus
typedef uintptr_t E;
#endif // __cplusplus

enum F
#ifdef __cplusplus
  : intptr_t
#endif // __cplusplus
 {
  f1 = 0,
  f2 = 2,
  f3,
  f4 = 5,
};
#ifndef __cplusplus
typedef intptr_t F;
#endif // __cplusplus

typedef enum {
  l1,
  l2,
  l3,
  l4,
} L;

enum M
#ifdef __cplusplus
  : int8_t
#endif // __cplusplus
 {
  m1 = -1,
  m2 = 0,
  m3 = 1,
};
#ifndef __cplusplus
typedef int8_t M;
#endif // __cplusplus

typedef enum {
  n1,
  n2,
  n3,
  n4,
} N;

enum O
#ifdef __cplusplus
  : int8_t
#endif // __cplusplus
 {
  o1,
  o2,
  o3,
  o4,
};
#ifndef __cplusplus
typedef int8_t O;
#endif // __cplusplus

typedef struct J J;

typedef struct K K;

typedef struct Opaque Opaque;

enum G_Tag
#ifdef __cplusplus
  : uint8_t
#endif // __cplusplus
 {
  Foo,
  Bar,
  Baz,
};
#ifndef __cplusplus
typedef uint8_t G_Tag;
#endif // __cplusplus

typedef struct {
  G_Tag tag;
  uint8_t x;
  int16_t y;
} Bar_Body;

typedef union {
  G_Tag tag;
  struct {
    G_Tag foo_tag;
    int16_t foo;
  };
  Bar_Body bar;
} G;

typedef enum {
  H_Foo,
  H_Bar,
  H_Baz,
} H_Tag;

typedef struct {
  uint8_t x;
  int16_t y;
} H_Bar_Body;

typedef struct {
  H_Tag tag;
  union {
    struct {
      int16_t foo;
    };
    H_Bar_Body bar;
  };
} H;

enum ExI_Tag
#ifdef __cplusplus
  : uint8_t
#endif // __cplusplus
 {
  ExI_Foo,
  ExI_Bar,
  ExI_Baz,
};
#ifndef __cplusplus
typedef uint8_t ExI_Tag;
#endif // __cplusplus

typedef struct {
  uint8_t x;
  int16_t y;
} ExI_Bar_Body;

typedef struct {
  ExI_Tag tag;
  union {
    struct {
      int16_t foo;
    };
    ExI_Bar_Body bar;
  };
} ExI;

enum P_Tag
#ifdef __cplusplus
  : uint8_t
#endif // __cplusplus
 {
  P0,
  P1,
};
#ifndef __cplusplus
typedef uint8_t P_Tag;
#endif // __cplusplus

typedef struct {
  uint8_t _0;
  uint8_t _1;
  uint8_t _2;
} P1_Body;

typedef struct {
  P_Tag tag;
  union {
    struct {
      uint8_t p0;
    };
    P1_Body p1;
  };
} P;

typedef enum {
  Ok,
  Err,
} Q_Tag;

typedef struct {
  Q_Tag tag;
  union {
    struct {
      uint32_t *ok;
    };
    struct {
      uint32_t err;
    };
  };
} Q;

typedef enum {
  IRFoo,
  IRBar,
  IRBaz,
} R_Tag;

typedef struct {
  uint8_t x;
  int16_t y;
} IRBar_Body;

typedef struct {
  R_Tag tag;
  union {
    struct {
      int16_t IRFoo;
    };
    IRBar_Body IRBar;
  };
} R;

#ifdef __cplusplus
extern "C" {
#endif // __cplusplus

void root(Opaque *opaque,
          A a,
          B b,
          C c,
          D d,
          E e,
          F f,
          G g,
          H h,
          ExI i,
          J j,
          K k,
          L l,
          M m,
          N n,
          O o,
          P p,
          Q q,
          R r);

#ifdef __cplusplus
} // extern "C"
#endif // __cplusplus

#if __cplusplus
#if FALSE
''' '
#endif

#include <stddef.h>
#include "testing-helpers.h"
static_assert(offsetof(CBINDGEN_STRUCT(P), tag) == 0, "unexpected offset for tag");
static_assert(offsetof(CBINDGEN_STRUCT(P), p0) == 1, "unexpected offset for p0");
static_assert(offsetof(CBINDGEN_STRUCT(P), p0) == 1, "unexpected offset for p1");
static_assert(sizeof(CBINDGEN_STRUCT(P)) == 4, "unexpected size for P");

#if FALSE
' '''
#endif
#endif
