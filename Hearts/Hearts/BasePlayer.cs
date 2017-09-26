using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    class BasePlayer
    {
        public readonly string Name;
        public readonly int Seat;
        public List<Card> Hand = new List<Card>(13);
        public List<Card> PassedCards = new List<Card>();
        public bool IsLeading { get; set; }
        public int PointsTaken { get; set; }

        public BasePlayer(string name, int seat)
        {
            Name = name;
            Seat = seat;
        }

        public virtual void SortHand()
        {
            Hand.Sort();
        }

        public virtual void PassCards()
        {

        }

        public virtual void InsertReceivedCards()
        {

        }

        public bool WhoStarts(List<Card> _hand)
        {
            string cardName;

            foreach(Card card in _hand)
            {
                cardName = card.Name;

                if (cardName == "2 of Clubs")
                {
                    return true;
                }
            }

            return false;
        }

        public string PrintHand()
        {
            string writeToForm = null;

            foreach (Card card in Hand)
            {
                writeToForm += card.Name + "\r\n";
            }

            return writeToForm;
        }
    }
}
