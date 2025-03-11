using System;

class RectangleAreaCalculator
{
    static void Main()
    {
        //iso muutos
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

       
        double area = length * width;

        
        Console.WriteLine($"The area of the rectangle is: {area}");

        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}