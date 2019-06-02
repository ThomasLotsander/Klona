using DataRepository;
using Klona.Business.Helpers;
using Klona.Models;
using System;
using System.Collections.Generic;

namespace Klona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var hand = new PlayingHand();

            var cards = new List<Card>();


            var data = new CardAccess();

            var deck = data.GetDeckOfCards();

            deck.Shuffle();

        }
    }
}
