using System.Globalization;

public class Baskhara
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        string line = Console.ReadLine();
        string[] parameters = line.Split(' ');

        double A = Convert.ToDouble(parameters[0]);
        double B = Convert.ToDouble(parameters[1]);
        double C = Convert.ToDouble(parameters[2]);

        double delta = (B * B) - (4 * A * C);

        if (delta < 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
            return;
        }

        double R1 = ((-1 * B) + Math.Sqrt(delta)) / (2 * A);
        double R2 = ((-1 * B) - Math.Sqrt(delta)) / (2 * A);

        Console.WriteLine($"R1 = {R1.ToString("F5")}");
        Console.WriteLine($"R2 = {R2.ToString("F5")}");


    }

}