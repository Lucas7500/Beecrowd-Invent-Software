using System.Globalization;

public class Triangulo
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        string line = Console.ReadLine();
        string[] parameters = line.Split(' ');

        double A = Convert.ToDouble(parameters[0]);
        double B = Convert.ToDouble(parameters[1]);
        double C = Convert.ToDouble(parameters[2]);
        bool isTrianglePossible;

        if (A > B && A > C)
        {
            isTrianglePossible = A > Math.Abs(B - C) && A < (B + C) ? true : false;
        }
        else if (B > A && B > C)
        {
            isTrianglePossible = B > Math.Abs(A - C) && B < (A + C) ? true : false;
        }
        else
        {
            isTrianglePossible = C > Math.Abs(A - B) && C < (A + B) ? true : false;
        }

        if (isTrianglePossible)
        {
            Console.WriteLine($"Perimetro = {(A + B + C).ToString("F1")}");
        }
        else
        {
            Console.WriteLine($"Area = {(((A + B) * C) / 2).ToString("F1")}");
        }

    }

}