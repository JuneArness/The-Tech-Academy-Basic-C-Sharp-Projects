using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {   

            

            // Allows program to create a deck of cards without having to input
            // Each card manually
            Deck deck = new Deck();

            int timesShuffled = 0;
            deck.Shuffle(3);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + "of" + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }
       
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i= 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        }
    }
}
