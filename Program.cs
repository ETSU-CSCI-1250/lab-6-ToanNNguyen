public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("SC for Show Character, RP for Retail Price, TT for Temperature Table, PN for Prime Number.");
        string userInput = Console.ReadLine();

        switch (userInput.Trim().ToUpper())
        {
            case "SC":
                ShowCharacter();
                break;
            case "RP":
                CalculateRetail();
                break;
            case "TT":
                for (int i = 80; i < 101; i++)
                {
                    Console.WriteLine($"{i} | {Celsius(i)}");
                }
                break;
            case "PN":
                IsPrime();
                break;
            default:
                break;
        }
    }
    static void ShowCharacter()
    {
        Console.Write("Enter word:");
        string wordInput = Console.ReadLine();

        Console.Write("Enter character position:");
        int characterPosition = int.Parse(Console.ReadLine());

        char showCharacter = wordInput[characterPosition - 1];

        Console.WriteLine(showCharacter);
    }
    static void CalculateRetail()
    {
        Console.Write("Enter Item Cost:");
        double costInput = double.Parse(Console.ReadLine());

        Console.Write("Enter Markup Percentage as decimal:");
        double markUp = double.Parse(Console.ReadLine());

        double totalPrice = (costInput + (markUp * costInput));

        Console.WriteLine($"Item's retail price is {totalPrice}");
    }
    static double Celsius(double Farenheit)
    {
        double Celsius1 = (Farenheit - 32) * 5 / 9;
        return Celsius1; 
    }
    static void IsPrime()
    {
        Console.Write("Enter number to check:");
        double primeInput = double.Parse(Console.ReadLine());
        bool IsPrime = true;

        for (int p = 2; p < primeInput; p++)
        {
            if (primeInput % 2 == 0)
            {
                IsPrime = false;
            }
        }
        if (IsPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}

