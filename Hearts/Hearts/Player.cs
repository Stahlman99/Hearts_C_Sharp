using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    class Player : BasePlayer
    {
        public new bool IsLeading { get; set; }
        public new int PointsTaken { get; set; }

        public Player(string name, int seat) : base(name, seat)
        {
        }

        //public override Card PlayCard()
        //{

        //}

        List<Card> tempHand = new List<Card>(13);
        int cardIDOne = -1;
        int cardIDTwo = -1;
        int cardIDThree = -1;
        string cardName;
        bool doesHaveSuit = false;

        public override void PassCards()
        {
            //PrintHand();
            //Console.WriteLine("Type the name of a card you would like to pass.");
            //cardName = Console.ReadLine();

            //while(GetIndexOfCard(cardName))
            //{
            //    PrintHand();
            //    Console.WriteLine("That is not a valid name, please type another.");
            //    cardName = Console.ReadLine();
            //}

            //PrintHand();
            //Console.WriteLine("Type the name of a card you would like to pass.");
            //cardName = Console.ReadLine();

            //while (GetIndexOfCard(cardName))
            //{
            //    PrintHand();
            //    Console.WriteLine("That is not a valid name, please type another.");
            //    cardName = Console.ReadLine();
            //}

            //PrintHand();
            //Console.WriteLine("Type the name of a card you would like to pass.");
            //cardName = Console.ReadLine();

            //while (GetIndexOfCard(cardName))
            //{
            //    PrintHand();
            //    Console.WriteLine("That is not a valid name, please type another.");
            //    cardName = Console.ReadLine();
            //}

            //TakePassedCardsOut();
        }

        //public bool GetIndexOfCard(string cardName)
        //{
        //    foreach (Card card in Hand)
        //    {
        //        if (card.Name == cardName)
        //        {
        //            if (cardIDOne == -1)
        //            {
        //                cardIDOne = Array.IndexOf(Hand, card);
        //                return false;
        //            }
        //            else if (cardIDTwo == -1)
        //            {
        //                cardIDTwo = Array.IndexOf(Hand, card);
        //                return false;
        //            }
        //            else if (cardIDThree == -1)
        //            {
        //                cardIDThree = Array.IndexOf(Hand, card);
        //                return false;
        //            }
        //        }
        //    }

        //    return true;
        //}

        //public void TakePassedCardsOut()
        //{
        //    int handLoopNum = 0;
        //    int passLoopNum = 0;

        //    foreach(Card card in Hand)
        //    {
        //        int ID = Array.IndexOf(Hand, card);

        //        if (ID == cardIDOne || ID == cardIDTwo || ID == cardIDThree)
        //        {
        //            PassedCards[passLoopNum] = Hand[ID];
        //            passLoopNum++;
        //        }
        //        else
        //        {
        //            tempHand[handLoopNum] = Hand[ID];
        //            handLoopNum++;
        //        }
        //    }
        //}

        //public override void InsertReceivedCards()
        //{
        //    int loopNum = 0;
        //    int tempLoopNum = 0;
        //    int gotLoopNum = 0;

        //    foreach (Card card in tempHand)
        //    {
        //        Hand[loopNum] = tempHand[tempLoopNum];
        //        loopNum++;
        //        tempLoopNum++;
        //    }

        //    if (PassedCards[0] == null)
        //        Console.WriteLine("Uh oh. PassedCards is empty");
        //    foreach (Card card in PassedCards)
        //    {
        //        Hand[loopNum] = PassedCards[gotLoopNum];
        //        loopNum++;
        //        gotLoopNum++;
        //    }
        //}

        //public Card PlayCard(string suit)
        //{
            //string input;
            //bool going = true;
            //Card outCard = new Card("null", "null", -1);

            //foreach(Card card in Hand)
            //{
            //    if (card.Suit == suit)
            //    {
            //        doesHaveSuit = true;
            //    }
            //}

            //while(going)
            //{
            //    Console.WriteLine("Play a card.");

            //    input = Console.ReadLine();
            //    int looper = 0;

            //    foreach (Card card in Hand)
            //    {
            //        looper++;

            //        if(card.Name == input)
            //        {
            //            if(IsPlayable(card, suit))
            //            {
            //                outCard = card;
            //                return card;
            //            }
            //            else
            //            {
            //                Console.WriteLine("That card is not playable.");
            //                break;
            //            }
            //        }

            //        if(card.Name != input && looper >= 13)
            //        {
            //            Console.WriteLine("That card is not playable.");
            //        }

            //    }

            //}

            //Console.WriteLine("Uh oh, you played an empty card.");
            //return outCard;
        //}

        //public bool IsPlayable(Card card, string suit)
        //{
        //    if(!doesHaveSuit)
        //    {
        //        return true;
        //    }
        //    else if (card.Suit == suit)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public void PrintHand()
        {
            Console.WriteLine("Your hand is ");
            Console.WriteLine();
            foreach (Card card in Hand)
            {
                if (card == null)
                {
                    break;
                }
                Console.WriteLine(card.Name + ", ");
            }
            Console.WriteLine();
        }
    }
}
