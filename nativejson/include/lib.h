#ifndef NATIVE_JSON_H
#define NATIVE_JSON_H
#include <cstddef>
#include <string>

namespace NativeJson
{
     extern "C"  std::string Compile(const char *file);
}

#endif
