using DataRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klona.Models
{
    public class PlayingHand
    {

        public int MaxNumberOfCards { get; private set; }

        public List<Card> Cards { get; set; } = new List<Card>();

        public PlayingHand()
        {
            MaxNumberOfCards = 3;

            // Set ut starting hand 
        }

    }
}
