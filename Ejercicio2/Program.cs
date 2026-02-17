using System;

class Program
{
    static void Main()
    {
        int width = 7;
        int height = 5;

        int area = width * height;
        int perimeter = (2 * width) + (2 * height);

        width += 3;
        height -= 2;

        area = width * height;
        perimeter = (2 * width) + (2 * height);

        Console.WriteLine("Width final: " + width);
        Console.WriteLine("Height final: " + height);
        Console.WriteLine("Area final: " + area);
        Console.WriteLine("Perimeter final: " + perimeter);
    }
}
