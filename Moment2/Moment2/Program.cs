using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Moment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FordonKlass> fordon = new List<FordonKlass>(); //Skapar en lista för att lagra fordon
            while (true)
            {
                Console.WriteLine("\nVälkommen till mitt program! Använd siffrorna 0-3 för att välja att:"); //Meny
                Console.WriteLine("0. Avsluta program");
                Console.WriteLine("1. Skriv ut en lista med dina fordon");
                Console.WriteLine("2. Lägg till fordon");
                Console.WriteLine("3. Ta bort fordon");
                char val = Console.ReadKey(true).KeyChar;
                Console.WriteLine("\n");
                switch (val)
                {
                    case '0':
                        return;
                    case '1':
                        FordonsLista(fordon);
                        break;
                    case '2':
                        LäggTillFordon(fordon);
                        break;
                    case '3':
                        TaBortFordon(fordon);
                        break;
                    default:
                        Console.WriteLine("Ogiltig Input, försök igen!");
                        break;
                }
            }
        }
        static void LäggTillFordon(List<FordonKlass> fordon) //Metod för att lägga till fordon till listan
        {
            string make;
            while (true) //Loop runt alla för felhantering
            {
                Console.Write("\nSkriv in märket av fordonet: ");
                make = Console.ReadLine(); //Tar in märket av fordonet
                if (!string.IsNullOrWhiteSpace(make))//Kollar att det inte är tomt
                {
                    break;
                }
                Console.WriteLine("\nDu kan inte lämna fältet tomt");
            }
            string model;
            while (true)
            {
                Console.Write("\nSkriv in modellen av fordonet: ");
                model = Console.ReadLine(); //Tar in modellen av fordonet
                if (!string.IsNullOrWhiteSpace(model))//Kollar att det inte är tomt
                {
                    break;
                }
                Console.WriteLine("\nDu kan inte lämna fältet tomt");
            }
            int year;
            while (true)
            {
                Console.Write("\nSkriv in årsmodellen av fordonet: ");
                if (int.TryParse(Console.ReadLine(), out year))
                {
                    break;
                }
                Console.WriteLine("\nOgiltig Input, försök igen!");
            }

            FordonKlass ettFordon = new FordonKlass(make, model, year); //Skapar ett fordon med hjälp av tidigare inputs och lägger in det i listan
            fordon.Add(ettFordon);
        }
        static void TaBortFordon(List<FordonKlass> fordon) //Metod för att ta bort fordon från listan
        {
            if (fordon.Count == 0) //Kollar att det finns fordon i listan
            {
                Console.WriteLine("Du har inga fordon att ta bort. \n");
                return;
            }
            for (int i = 0; i < fordon.Count; i++)
            {
                Console.WriteLine($"ID: {i} | {fordon[i]}");
            }
            Console.Write("\n");
            int val;
            while (true)
            {
                Console.Write("\nVälj ID för fordonet du vill ta bort: ");
                if (int.TryParse(Console.ReadLine(), out val)) //Tar in id man villt a bort
                {
                    break;
                }
                Console.WriteLine("Ogiltig Input, försök igen!");
            }
            if (val >= 0 && val < fordon.Count) //Kollar att id finns och tar bort det
            {
                fordon.RemoveAt(val);
            }
            else
            {
                Console.WriteLine($"Id {val} hittades inte.");
            }
        }
        static void FordonsLista(List<FordonKlass> fordon) //Metod som skriver ut fordonen i listan
        {
            if (fordon.Count == 0) //Kollar att det finns fordon i listan
            {
                Console.WriteLine("Du har inga fordon i listan. \n");
            }
            for (int i = 0; i < fordon.Count; i++) //Skriver ut fordonen
            {
                Console.WriteLine($"ID: {i} | {fordon[i]}");
            }
        }
    }
}
