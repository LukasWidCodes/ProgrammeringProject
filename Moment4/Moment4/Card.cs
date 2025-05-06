using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment4
{
    public class Card
    {
        private CardSuit cardsuit; //Privat fält som håller kortets färg
        private Value value; //Privat fält som håller kortets värde

        public Card(CardSuit cardsuit, Value value) //Konstruktor som skapar ett kort med en given färg och värde
        {
            this.cardsuit = cardsuit; //Sätter kortets färg
            this.value = value; //Sätter kortets värde
        }

        public CardSuit GetCardSuit() //Metod som returnerar kortets färg
        {
            return cardsuit;
        }
        public Value GetValue() //Metod som returnerar kortets värde
        {
            return value;
        }
        public override string ToString() //Metod som returnerar kortets information som en sträng
        {
            return $"{cardsuit}  {value}";
        }
        public enum Value //Enum som definierar alla möjliga kortvärden
        {
            Ace = 1, //Ess
            Deuce = 2, //Två
            Three = 3, //Tre o.s.v
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11, //Knekt
            Queen = 12, //Dam
            King = 13 //Kung
        }
        public enum CardSuit //Enum som definierar de fyra kortfärgerna
        {
            Club = 0,
            Diamonds = 1,
            Spades = 2,
            Hearts = 3
        }
    }
}
