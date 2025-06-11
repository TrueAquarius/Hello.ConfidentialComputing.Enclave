#include "Enclave_t.h"
#include <string>
#include <sstream>

int word_count(const char* input)
{
    std::istringstream iss(input);
    int count = 0;
    std::string word;
    while (iss >> word) ++count;
    return count;
}
