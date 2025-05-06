using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment4
{
    public class Deck
    {
        public List<Card> cardDeckList; //Lista med alla kort
        private Random randomizer = new Random();
        public Deck() //Konstruktor som skapar kortleken genom att loopa igen alla färger och värden
        {
            cardDeckList = new List<Card>();
            //Loopar igenom alla möjliga färger (CardSuit) och värden (Card.Value) för att skapa alla kort
            foreach (Card.CardSuit suit in Enum.GetValues(typeof(Card.CardSuit)))
            {
                foreach (Card.Value value in Enum.GetValues(typeof(Card.Value)))
                {
                    cardDeckList.Add(new Card(suit, value)); //Läägger till varje kort i listan
                }
            }
        }
        public Card DrawCard() //"Drar" ett slumpvis kort från listan
        {
            int randomNumber = randomizer.Next(0, cardDeckList.Count);
            Card returnCard = cardDeckList[randomNumber];
            cardDeckList.RemoveAt(randomNumber); //Tar bort kortet från listan så det inte kan dras igen
            return returnCard;
        }
    }
}
