using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bilmärken = { "Volvo", "BMW", "Audi", "Toyota", "Opel" }; //Skapar en array med förbestämda bilmärken
            while (true) 
            {
                Console.WriteLine("\nVälkommen till mitt program! Använd siffrorna 1-3 för att välja att:"); //Skriver en "meny"
                Console.WriteLine("1. Skriv ut bilmärken");
                Console.WriteLine("2. Ersätt ett bilmärke");
                Console.WriteLine("3. Avsluta program");
                char svar = Console.ReadKey(true).KeyChar; //Tar in vad användaren har tryckt ner. (true) så att det inte visar vad man tryckt ner vilket ser bättre ut, trycker jag.
                Console.WriteLine("\n");
                switch (svar) //Beroende på vad användaren har tryckt så händer olika saker
                {
                    case '1': //1 metod som skriver ut bilmärkena i arrayen
                        SkrivFordon(bilmärken);
                        break;
                    case '2': //2 metod som låter användaren ändra på ett bilmärke
                        ErsättFordon(bilmärken);
                        break;
                    case '3': //3 avslutar programmet
                        Console.WriteLine("Programmet avslutas");
                        return;
                    default: //Om användaren inte tryckt ner 1-3 så händer detta
                        Console.WriteLine("Ogiltigt val, försök igen!");
                        break;
                }
            }
        }
        static void ErsättFordon(string[] bilmärken)
        {
            bool santFalskt = false; //Kontroll för om ett bilmärke finns och ersätts
            Console.WriteLine("Vilket fordon vill du ersätta?");
            string svar2 = Console.ReadLine(); //Tar in bilmärket användaren vill ändra
            for (int i = 0; i < bilmärken.Length; i++) //Loop som går igenom arrayen och kollar om det användaren skrev in matchar ett av bilmärkena
            {
                if (svar2 == bilmärken[i]) //Om bilmärket hittas händer detta
                {
                    Console.WriteLine($"Vad vill du ersätta {bilmärken[i]} med?");
                    bilmärken[i] = Console.ReadLine(); //Ersätter bilmärket med det nya
                    santFalskt = true; //Visar att det fungerat
                }
            }
            if (!santFalskt) //Om det inte fungerar (inget bilmärke hittades) händer detta
            {
                Console.WriteLine("Bilmärket hittades inte! Kontrollera stavningen(skriv ut bilmärkena om du glömt).");
            }
        }
        static void SkrivFordon(string[] bilmärken)
        {
            Console.WriteLine("Dina bilmärken är:\n");
            foreach (string bil in bilmärken) //Loop som går igenom arrayen
            {
                Console.WriteLine(bil); //Skriver ut varje bilmärke
            }
        }
    }
}