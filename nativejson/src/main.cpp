#include <iostream>
#include "lib.h"

int main() {
    std::cout << NativeJson::Compile("Hello World") << std::endl;
    return 0;
}