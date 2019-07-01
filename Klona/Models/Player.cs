using System;
using System.Collections.Generic;
using System.Text;

namespace Klona.Models
{
    public class Player
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public PlayingHand Hand { get; set; }
        public PlayerBoard Board { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new PlayingHand();
            Board = new PlayerBoard();
        }
    }
}
