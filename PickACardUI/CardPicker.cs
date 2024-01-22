using System;

namespace PickACardUI
{
    class CardPicker
    { 
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + "of" + RandomSuit();
            }
            return pickedCards;
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