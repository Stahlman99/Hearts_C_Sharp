using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    public class Card : IComparable<Card>
    {
        public readonly string Name;
        public readonly Type Rank;
        public readonly Suits Suit;
        //HierarchyNum tells the actual value of the card. i.e. Ace = 13
        public string Owner { get; set; }

        public Card(Type _rank, Suits _suit)
        {
            Rank = _rank;
            Suit = _suit;
            Name = (_rank.ToString() + " of " + _suit.ToString());
        }

        public int CompareTo(Card that)
        {
            if(this.Suit == that.Suit)
            {
                if(this.Rank > that.Rank)
                {
                    return -1;
                }
                if(that.Rank > this.Rank)
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("Card.cs/CompareTo() One or more cars is not valid!");
                }
            }
            if(this.Suit > that.Suit)
            {
                return -1;
            }
            if (that.Suit > this.Suit)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("Card.cs/CompareTo() One or more cars is not valid!");
                return 0;
            }

        }
    }

    public enum Suits
    {
        Hearts = 1,
        Diamonds = 2,
        Spades = 3,
        Clubs = 4
    }

    public enum Type
    {
        Ace = 14,
        King = 13,
        Queen = 12,
        Jack = 11,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5,
        Four = 4,
        Three = 3,
        Two = 2
    }
}
