cmake_minimum_required(VERSION 3.24.3)
project(nativejson VERSION 1.0 DESCRIPTION "NativeJson" LANGUAGES CXX)
set (CMAKE_CXX_STANDARD 17)

add_library(nativejson SHARED src/main.cpp  src/lib.cpp )
set_target_properties(nativejson PROPERTIES
    VERSION ${PROJECT_VERSION}
    SOVERSION 1
    PUBLIC_HEADER include/lib.h)
target_include_directories(nativejson PRIVATE include)