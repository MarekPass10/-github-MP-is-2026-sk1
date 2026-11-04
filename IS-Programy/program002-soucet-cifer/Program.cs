using System;

while (true)
{
    Console.Write("\nZadejte celé číslo (nebo 'exit' pro ukončení): ");
    string inputStr = Console.ReadLine();

    if (string.Equals(inputStr, "exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    if (!int.TryParse(inputStr, out int number))
    {
        Console.WriteLine("Chyba: Zadejte platné celé číslo.");
        continue;
    }

    int numToProcess = Math.Abs(number);
    int sum = 0;
    long product = 1;

    if (numToProcess == 0)
    {
        sum = 0;
        product = 0;
    }
    else
    {
        while (numToProcess > 0)
        {
            int digit = numToProcess % 10;
            sum += digit;
            product *= digit;
            numToProcess /= 10;
        }
    }

    Console.WriteLine($"Číslo (bez znaménka): {Math.Abs(number)}");
    Console.WriteLine($"Součet cifer: {sum}");
    Console.WriteLine($"Součin cifer: {product}");
    Console.WriteLine("---------------------------------------------");
}
