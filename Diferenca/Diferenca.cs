public class Diferenca
{
    public static void Main(string[] args)
    {
        int A, B, C, D;
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        D = Convert.ToInt32(Console.ReadLine());

        int result = (A * B) - (C * D);

        Console.WriteLine("DIFERENCA = " + result);
    }
}