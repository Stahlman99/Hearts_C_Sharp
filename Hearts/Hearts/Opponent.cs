using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    class Opponent : BasePlayer
    {
        public new bool IsLeading { get; set; }
        public new int PointsTaken { get; set; }

        public Opponent(string name, int seat) : base(name, seat)
        {

        }

        int cardIDOne = -1;
        int cardIDTwo = -1;
        int cardIDThree = -1;
        Card passedOne;
        Card passedTwo;
        Card passedThree;




        public override void PassCards()
        {
        }

        //public void PrintHand()
        //{
        //    Console.WriteLine("This Oponents hand is: ");
        //    Console.WriteLine();
        //    foreach (Card card in Hand)
        //    {
        //        if (card == null)
        //        {                    
        //            Console.WriteLine("This card is empty");
        //            continue;
        //        }
        //        Console.WriteLine(card.Name + ", ");
        //    }
        //    Console.WriteLine();
        //}

        //public Card PlayCard(string suit)
        //{
        //    Card noCard = new Card("None", "None", 12);
        //    return noCard;
        //}
    }
}
