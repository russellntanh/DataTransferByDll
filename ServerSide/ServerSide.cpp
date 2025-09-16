// ServerSide.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

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

// Export a function for C# to call
extern "C" __declspec(dllexport) float CalculateArea(float w, float h)
{
    Calculation calc;
    return calc.Area(w, h);
}

extern "C" __declspec(dllexport) float CalculatePerimeter(float w, float h)
{
    Calculation calc;
    return calc.Perimeter(w, h);
}

int main()
{

}
