using System.Globalization;

public class Area
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        double pi = 3.14159;

        string line = Console.ReadLine();
        string[] sides = line.Split(' ');

        double A = Convert.ToDouble(sides[0]);
        double B = Convert.ToDouble(sides[1]);
        double C = Convert.ToDouble(sides[2]);

        Console.WriteLine($"TRIANGULO: {((A * C) / 2).ToString("F3")}");
        Console.WriteLine($"CIRCULO: {(pi * (C * C)).ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {(((A + B) * C) / 2).ToString("F3")}");
        Console.WriteLine($"QUADRADO: {(B * B).ToString("F3")}");
        Console.WriteLine($"RETANGULO: {(A * B).ToString("F3")}");

    }

}