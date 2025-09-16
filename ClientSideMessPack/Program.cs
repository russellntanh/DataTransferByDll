using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using KeyAttribute = MessagePack.KeyAttribute;

namespace ClientSideMessPack
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle { width = 4, height = 5 };

        Console.WriteLine("Calculated Result:");

        // Perimeter (chu vi)
        float peri = CalculatePerimeter(rectangle.width, rectangle.height);
        Console.WriteLine("Perimeter = " + peri);

        // Area (dien tich)
        float area = CalculateArea(rectangle.width, rectangle.height);
        Console.WriteLine("Area = " + area);

    }

    [MessagePackObject] // false : only serialize Key
    public class InputParams
    {
        [Key(0)] public float width { get; set; } = 4.0f;
        [Key(1)] public float height { get; set; } = 5.0f;
    }

    [MessagePackObject]
    public class OutputParams
    {
        [Key(0)] public float Area { get; set; }
        [Key(1)] public float Perimeter { get; set; }
    }
}
