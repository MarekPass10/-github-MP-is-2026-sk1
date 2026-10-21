using System;

class Program
{
   static void Main()
   {
       Console.Write("Zadejte celé číslo: ");
       string input = Console.ReadLine();

       int sum = 0;
       int product = 1;
       bool hasDigits = false;

       // Procházíme každý znak v zadaném textu
       foreach (char c in input)
       {
           // Kontrola, zda je znak číslice (přeskočí znaménka - nebo +)
           if (char.IsDigit(c))
           {
               int digit = c - '0'; // Převod znaku na číslo
               sum += digit;
               product *= digit;
               hasDigits = true;
           }
       }

       if (hasDigits)
       {
           Console.WriteLine($"Ciferný součet: {sum}");
           Console.WriteLine($"Ciferný součin: {product}");
       }
       else
       {
           Console.WriteLine("Zadaný text neobsahoval žádné číslice.");
       }
   }
}
 