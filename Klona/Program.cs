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
            var data = new CardAccess();
            var deck = data.GetDeckOfCards();

            var p1 = new Player("Thomas");
            var p2 = new Player("Micke");
            deck.Shuffle();
            Game game = new Game(p1, p2, deck);
            game.Play();


            

        }
    }
}
