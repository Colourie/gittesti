using System;

class TemperatureConverter
{
    static void Main()
    {
        // Prompt the user for the temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Display the result
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");

        // Exit gracefully
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}