using System.Globalization;

public class Salario
{
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        string name = Console.ReadLine();
        double fixedSalary = Convert.ToDouble(Console.ReadLine());
        double comission = Convert.ToDouble(Console.ReadLine());
        double total = fixedSalary + (comission * 0.15);

        Console.WriteLine($"TOTAL = R$ {total.ToString("F2")}");
    }
}