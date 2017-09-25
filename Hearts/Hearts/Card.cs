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
        public readonly string Suit;
        //HierarchyNum tells the actual value of the card. i.e. Ace = 13
        public readonly int HierarchyNum;
        public string Owner { get; set; }
        public int SuitNumber
        {
            get
            {
                int output;
                if(Suit == "Hearts")
                {
                    output = 4;
                }
                if (Suit == "Diamonds")
                {
                    output = 3;
                }
                if (Suit == "Spades")
                {
                    output = 2;
                }
                else
                {
                    output = 1;
                }
                return output;
            }
        }

        public Card(string name, string suit, int hierarchyNum)
        {

            Name = name;
            Suit = suit;
            HierarchyNum = hierarchyNum;
        }

        public int CompareTo(Card that)
        {
            if(this.SuitNumber == that.SuitNumber)
            {
                if(this.HierarchyNum > that.HierarchyNum)
                {
                    return -1;
                }
                if(that.HierarchyNum > this.HierarchyNum)
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("Card.cs/CompareTo() One or more cars is not valid!");
                }
            }
            if(this.SuitNumber > that.SuitNumber)
            {
                return -1;
            }
            if (that.SuitNumber > this.SuitNumber)
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
}
