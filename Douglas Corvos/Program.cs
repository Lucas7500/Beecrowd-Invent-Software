int grito = 0;
int soma = 0;
do
{
    string crow = Console.ReadLine();

    if (crow != "caw caw")
    {
        switch (crow)
        {
            case "---":
                soma += 0;
                break;
            case "--*":
                soma += 1;
                break;
            case "-*-":
                soma += 2;
                break;
            case "-**":
                soma += 3;
                break;
            case "*--":
                soma += 4;
                break;
            case "*-*":
                soma += 5;
                break;
            case "***":
                soma += 7;
                break;
            case "**-":
                soma += 6;
                break;
            default:
                break;
        }
    }
    else
    {
        Console.WriteLine(soma);
        soma = 0;
        grito++;
    }

} while (grito <= 2);