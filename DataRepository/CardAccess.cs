using Klona.Business.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository
{
    public class CardAccess
    {
        public List<Card> GetDeckOfCards()
        {
            var deck = SetUpDeckOfCards();
            return deck;
        }

        private List<Card> SetUpDeckOfCards()
        {
            var deck = new List<Card>();

            

            for (int i = 1; i < 5; i++)
            {                
               string suit = CardHelper.GetCardSuit(i); 
                for (int number = 2; number < 15; number++)
                {
                    bool isPointCard = false;
                    int grade = 1;
                    string value = number.ToString();

                    if (number < 5)
                    {
                        isPointCard = true;
                    }
                    else if (number > 9)
                    {
                        grade = 2;
                        value = CardHelper.GetCardValue(number);

                        if (number == 14)
                        {
                            grade = 3;
                        }
                    }

                    var card = new Card(suit, value, grade, isPointCard);
                    deck.Add(card);
                }
            }

            var joker1 = new Card("Red", "Joker", 0, false);
            var joker2 = new Card("Black", "Joker", 0, false);
            deck.Add(joker1);
            deck.Add(joker2);

            return deck;
        }
    }
}
