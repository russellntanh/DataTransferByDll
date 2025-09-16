using System.Runtime.InteropServices;

namespace ClientSide
{
    internal class Program
    {
        // Import the Cpp function from DLL
        [DllImport("ServerSide.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float CalculateArea(float w, float h);

        [DllImport("ServerSide.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float CalculatePerimeter(float w, float h);


        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle { width = 4, height = 5};
            
            Console.WriteLine("Calculated Result:");

            // Perimeter (chu vi)
            float peri = CalculatePerimeter(rectangle.width, rectangle.height);
            Console.WriteLine("Perimeter = " + peri);

            // Area (dien tich)
            float area = CalculateArea(rectangle.width, rectangle.height);            
            Console.WriteLine("Area = " + area);
            
        }
    }

    public class Rectangle
    {
        public float width { get; set; } = 4.0f;
        public float height { get; set; } = 5.0f;
    }
}
