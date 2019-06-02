using System;

namespace DataRepository
{
    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }
        public int Grade { get; set; }
        public bool IsPointCard { get; set; }

        public Card(string suit, string value, int grade, bool isPointCard)
        {
            Suit = suit;
            Value = value;
            Grade = grade;
            IsPointCard = isPointCard;

        }
    }
}
