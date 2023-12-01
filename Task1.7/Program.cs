using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("3");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit} *F");
    }
    static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}