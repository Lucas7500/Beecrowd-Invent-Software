public class Corvos
{
    static void Main(string[] args)
    {
        int sum, screams = 0, i = 0;
        string line;
        int[] result = new int[3];

        while (screams < 3)
        {
            sum = 0;

            while (true)
            {
                line = Console.ReadLine();

                if (line == "caw caw")
                {
                    break;
                }

                sum += ConvertToNumber(line); // --*
            }

            result[i] = sum;
            i++;
            screams++;
        }

        for (i = 0; i < 3; i++)
        {
            Console.WriteLine(result[i]);
        }

    }

    static public int ConvertToNumber(string eyes)
    {
        int num = 0;

        for (int i = 2, exponent = 0; i >= 0; i--, exponent++)
        {
            num += ConvertToBinary(eyes[i]) * Convert.ToInt32(Math.Pow((double)2, (double)exponent));
        }

        return num;
    }

    static private int ConvertToBinary(char symbol)
    {
        if (symbol == '-')
        {
            return 0;
        }

        return 1;
    }

}