using System;
using System.Linq;

namespace PickAUniqueCardUI
{
    class CardPicker
    { 
        static Random random = new Random();
        static string[] cards = new string[52];
        // generates deck of card; 
        static CardPicker()
        {
            string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
            int cardCounter = 0;
            for(int cardVal = 1; cardVal <=13; cardVal++)
            {
                foreach(string cardSuit in suits)
                {
                    string cardName;
                    if(cardVal == 11)
                    {
                        cardName = "Jack";
                    } else if (cardVal == 12)
                    {
                        cardName = "Queen";
                    } else if (cardVal == 13)
                    {
                        cardName = "King";
                    } else if (cardVal == 1)
                    {
                        cardName = "Ace";
                    }

                    // if number is 1 & 11-13, give it a name
                    cardName = cardVal.ToString();
                    cards[cardCounter] =  cardName + " of " + cardSuit;
                    cardCounter++;
                }
            }
            for (var i = 0; i <52; i++)
            {
                Console.WriteLine(cards[i]);
            }
        }
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                // pickedCards[i] = RandomValue() + "of" + RandomSuit();
                pickedCards[i] = RandomCard();
            }
            return pickedCards;
        }

        private static string RandomCard()
        {
            int cardNum = random.Next(0, cards.Length);
            string picked = cards[cardNum];
            cards = cards.Where(e => e != picked).ToArray();
            return picked;

        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1)
            {
                return "Ace";
            }
            else if (value == 11)
            {
                return "Jack";
            }
            else if (value == 12)
            {
                return "Queen";
            }
            else if (value == 13)
            {
                return "King";
            }
            return value.ToString();

        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1)
            {
                return "Spades";
            }
            else if (value == 2)
            {
                return "Hearts";
            }
            else if (value == 3)
            {
                return "Clubs";
            }
            return "Diamonds";
        }
    }
}