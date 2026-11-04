string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Výpis řady ***********");
    Console.WriteLine("*******************************");
    Console.WriteLine("******** Marek Passian ********");
    Console.WriteLine("*******************************");

  // Vstup počáteční hodnoty
Console.Write("Zadejte první číslo řady (celé číslo): ");
int first;
while (!int.TryParse(Console.ReadLine(), out first))
{
   Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
}

// Načtení koncové hodnoty řady
Console.Write("Zadejte poslední číslo řady (celé číslo): ");
int last;
while (!int.TryParse(Console.ReadLine(), out last))
{
   Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
}

// Načtení diference s kontrolou kladného nenulového čísla
Console.Write("Zadejte diferenci (kladné celé číslo): ");
int step;
while (!int.TryParse(Console.ReadLine(), out step)) 
{
   Console.Write("Nezadali jste celé číslo. Zadejte diferenci znovu: ");
}

    



}
