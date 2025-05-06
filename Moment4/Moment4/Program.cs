using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Moment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uppgift A)

            List<double> talLista = new List<double>();
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Skriv in nummer. Om du skriver 0 så avslutas loopen");
                if (double.TryParse(Console.ReadLine(), out double val))
                {
                    if (val == 0)
                    {
                        loop = false;
                    }
                    else
                    {
                        talLista.Add(val); //Lägger till nummret i listan
                        double summa = talLista.Sum(); //Räknar ut summan av alla inmatade nummer
                        double medelvärde = summa / talLista.Count; //Beräknar medelvärdet genom att dividera summan med antalet tal

                        Console.WriteLine($"Medelvärdet är: {medelvärde}");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning, försök igen!");
                }
            }
            Console.WriteLine("\n");

            //Uppgift B)

            Deck deck = new Deck(); //Skapar en kortlek
            while (deck.cardDeckList.Count > 0) //Loopar igenom hela kortleken och drar kort tills den blir tom
            {
                Card drawnCard = deck.DrawCard();
                Console.WriteLine($"You drew: {drawnCard}");
            }
            Console.WriteLine("\n");
            Console.ReadLine();

            //Uppgift C)

            Dictionary<string, int> cardDictionary = new Dictionary<string, int>();
            string[] suits = { "k", "r", "s", "h" }; //Kortfärger: klöver (k), ruter (r), spader (s), hjärter (h)
            string[] värden = { "E", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "K" }; //Kortvärden: Ess, 2-10, Knekt, Dam, Kung
            foreach (string suit in suits) //Loopar igenom alla färger
            {
                for (int j = 0; j < värden.Length; j++) //Loopar igenom alla värden
                {
                    string key = suit + värden[j]; //Skapar nyckeln, t.ex. "hE" för hjärter ess
                    int value = j + 1; //Räknar ut kortets poängvärde (Ess = 1, Kung = 13)
                    cardDictionary.Add(key, value); //Lägger till nyckel + värde i dictionaryn
                }
            }
            Random random = new Random();
            List<string> keys = cardDictionary.Keys.ToList(); //Lägger alla kort-nycklar i en lista så man kan slumpa
            int par = 0; //Räknar antal par

            for (int i = 0; i < 1000; i++) //1000 "dragningar"
            {
                string key1 = keys[random.Next(keys.Count)]; //Slumpar kort från listan
                string key2 = keys[random.Next(keys.Count)]; //Slumpar kort från listan

                int värde1 = cardDictionary[key1]; //Kollar vad för värde kortet har
                int värde2 = cardDictionary[key2]; //Kollar vad för värde kortet har

                if (värde1 == värde2) //Om värderna är samma händer detta
                {
                    Console.WriteLine($"Par {key1} och {key2}");
                    par++;
                }
            }
            Console.WriteLine($"Det blev par {par} gånger"); //Skriver ut antal par som blev dragna
            Console.WriteLine("\n");
            Console.ReadLine();

            //Uppgift D)
            //Fördefinierad text från boken Alice's Adventures in Wonderlan : https://www.gutenberg.org/cache/epub/11/pg11-images.html
            string text = "There was nothing so very remarkable in that; nor did Alice think it so very much out of the way to hear the Rabbit say to itself, “Oh dear! Oh dear! I shall be late!” (when she thought it over afterwards, it occurred to her that she ought to have wondered at this, but at the time it all seemed quite natural); but when the Rabbit actually took a watch out of its waistcoat-pocket, and looked at it, and then hurried on, Alice started to her feet, for it flashed across her mind that she had never before seen a rabbit with either a waistcoat-pocket, or a watch to take out of it, and burning with curiosity, she ran across the field after it, and fortunately was just in time to see it pop down a large rabbit-hole under the hedge.";
            UppgiftD(text);
            Console.WriteLine("Skriv en mening/text"); //Om man själv också vill skriva in något.
            string mening = Console.ReadLine();
            UppgiftD(mening);
        }
        static void UppgiftD(string mening) //Gjorde det till en metod så jag kunde ha en text som redan finns och en som man själv kan skriva
        {
            char[] begonePunkts = { '.', ',', '?', '!', ';' }; //Array med olika tecken (punkt, komma o.s.v)

            foreach (char c in begonePunkts) //Loopar för alla tecken i begonePunkts och ersätter alla tecken som existerar i mening med en tom sträng
            {
                mening = mening.Replace(c.ToString(), "");
            }

            string[] meningDelad = mening.Split(' '); //Delar mening i en array

            Dictionary<string, int> minDictionary = new Dictionary<string, int>();

            foreach (string m in meningDelad) //Loopa igenom varje ord i den delade meningen
            {
                if (minDictionary.ContainsKey(m)) //Om ordet redan finns i dictionaryn, öka dess räknare
                {
                    minDictionary[m]++;
                }
                else
                {
                    minDictionary.Add(m, 1); //Om ordet inte finns, lägg till det i dictionaryn med räknare satt till 1
                }
            }

            //Loopa igenom dictionaryn och skriv ut orden i ordning efter deras förekomst, från flest till minst
            foreach (KeyValuePair<string, int> m in minDictionary.OrderByDescending(x => x.Value)) // OrderByDescending hittade jag: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderbydescending?view=net-9.0 och sedan i denna sida under OrderByDescending som jag tyckte var klarare än microsofts https://www.tutorialsteacher.com/linq/linq-sorting-operators-orderby-orderbydescending#orderbydescending
            {
                Console.WriteLine($"Ordet {m.Key} förekommer {m.Value} gånger");
            }
            Console.WriteLine("\n");
        }
    }
}