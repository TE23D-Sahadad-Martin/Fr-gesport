using System;

class Program
{
     static int Main() 
    {
        int poäng = 0; // Variabel för att hålla koll på rätta svar

        Console.WriteLine("Välkommen till frågesporten!");

        // Fråga 1
        Console.WriteLine("Fråga 1: Vilken färg har himlen vanligtvis?");
        Console.WriteLine("1. Grön");
        Console.WriteLine("2. Blå");
        Console.WriteLine("3. Röd");
        string svar1 = Console.ReadLine();

        if (svar1 == "2")
        {
            Console.WriteLine("Rätt svar!");
            poäng++; // Öka poängen om svaret är rätt
        }
        else
        {
            Console.WriteLine("Fel svar.");
        }

        // Fråga 2
        Console.WriteLine("Vad är 8*8?")
        Console.WriteLine("1. 67");
        Console.WriteLine("2. 0");
        Console.WriteLine("3. 64");
        string svar2 = Console.ReadLine();

        if (svar2 == "2")
        {
            Console.WriteLine("Rätt svar!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel svar.");
        }

        // Fråga 3
        Console.WriteLine("Fråga 3: Vilket år började andra världskriget?");
        Console.WriteLine("1. 1939");
        Console.WriteLine("2. 1945");
        Console.WriteLine("3. 1914");
        string svar3 = Console.ReadLine();

        if (svar3 == "1")
        {
            Console.WriteLine("Rätt svar!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel svar.");
        }

        Console.WriteLine("\nDu fick " + poäng + " av 3 poäng rätt!");

        if (poäng == 3)
        {
            Console.WriteLine("Fantastiskt! Du fick alla rätt!");
        }
        else if (poäng == 2)
        {
            Console.WriteLine("Bra jobbat! Du fick nästan alla rätt.");
        }
        else if (poäng == 1)
        {
            Console.WriteLine("Du fick ett rätt, min icke existerande hund fick bättre resultat");
        }
        else
        {
            Console.WriteLine("Inga rätt!, kanske dags att tänka på framtiden");
        }

        Console.WriteLine("Tack för att du spelade!");
    }
}
