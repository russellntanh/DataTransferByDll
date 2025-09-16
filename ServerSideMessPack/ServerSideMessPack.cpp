// ServerSideMessPack.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <msgpack.hpp>

struct InputParams
{
    float w;
    float h;
    MSGPACK_DEFINE(w, h);
};

struct OutputParams
{
    float area;
    float perimeter;
};

class Calculation
{
public:
    float Area(float w, float h)
    {
        return w * h;
    }

    float Perimeter(float w, float h)
    {
        return (w + h) * 2;
    }
};

int main()
{
    std::cout << "Hello World!\n";
}