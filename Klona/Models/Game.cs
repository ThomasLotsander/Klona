using DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klona.Models
{
   public class Game
   {
       private Player player1;
       private Player player2;
       private List<Card> deck = new List<Card>();

        public Game(Player player1, Player player2, List<Card> deck)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.deck = deck;
            SetupPlayerStartingHand(player1, deck);
            SetupPlayerStartingHand(player2, deck);

            
        }


        public void Play()
        {
            Console.WriteLine("player 1 cards: ");
            foreach (var card in player1.Hand.Cards)
            {
                Console.WriteLine(card.Value + " of " + card.Suit + " Points: " + card.IsPointCard);
            }

            Console.WriteLine();
            Console.WriteLine("player 1 cards: ");
            foreach (var card in player2.Hand.Cards)
            {
                Console.WriteLine(card.Value + " of " + card.Suit + " Points: " + card.IsPointCard);
            }
        }

        private void SetupPlayerStartingHand(Player player, List<Card> deck)
        {
            Console.WriteLine("deck count: " + deck.Count);
            var startingCards = deck.Take(8);
            foreach (var card in startingCards.OrderBy(c => c.Value))
            {
                deck.Remove(card);
                player.Hand.Cards.Add(card);
            }

            Console.WriteLine("deck count: " +deck.Count);

            var x = 1337M;
            

        }
    }
}
