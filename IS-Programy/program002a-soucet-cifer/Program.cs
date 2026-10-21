using System;

class Program
{
   static void Main()
   {
       Console.Write("Zadejte celé číslo: ");
       if (!int.TryParse(Console.ReadLine(), out int inputNum))
       {
           Console.WriteLine("Neplatný vstup!");
           return;
       }

       int number = Math.Abs(inputNum); // Vyřešíme případná záporná čísla

       if (number == 0)
       {
           Console.WriteLine("Ciferný součet: 0");
           Console.WriteLine("Ciferný součin: 0");
           return;
       }

       int sum = 0;
       int product = 1;

       while (number > 0)
       {
           int digit = number % 10; // Získání poslední cifry
           sum += digit;            // Přičtení k součtu
           product *= digit;        // Vynásobení součinu
           number /= 10;            // Odstranění poslední cifry
       }

       Console.WriteLine($"Ciferný součet: {sum}");
       Console.WriteLine($"Ciferný součin: {product}");
   }
}
 