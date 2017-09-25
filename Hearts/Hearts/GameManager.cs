using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    class GameManager
    {
        private Card[] startingDeck = 
        {
            #region Cards
            new Card("2 of Spades", "Spades", 1),
            new Card("3 of Spades", "Spades", 2),
            new Card("4 of Spades", "Spades", 3),
            new Card("5 of Spades", "Spades", 4),
            new Card("6 of Spades", "Spades", 5),
            new Card("7 of Spades", "Spades", 6),
            new Card("8 of Spades", "Spades", 7),
            new Card("9 of Spades", "Spades", 8),
            new Card("10 of Spades", "Spades", 9),
            new Card("Jack of Spades", "Spades", 10),
            new Card("Queen of Spades", "Spades", 11),
            new Card("King of Spades", "Spades", 12),
            new Card("Ace of Spades", "Spades", 13),
            new Card("2 of Clubs", "Clubs", 1),
            new Card("3 of Clubs", "Clubs", 2),
            new Card("4 of Clubs", "Clubs", 3),
            new Card("5 of Clubs", "Clubs", 4),
            new Card("6 of Clubs", "Clubs", 5),
            new Card("7 of Clubs", "Clubs", 6),
            new Card("8 of Clubs", "Clubs", 7),
            new Card("9 of Clubs", "Clubs", 8),
            new Card("10 of Clubs", "Clubs", 9),
            new Card("Jack of Clubs", "Clubs", 10),
            new Card("Queen of Clubs", "Clubs", 11),
            new Card("King of Clubs", "Clubs", 12),
            new Card("Ace of Clubs", "Clubs", 13),
            new Card("2 of Diamonds", "Diamonds", 1),
            new Card("3 of Diamonds", "Diamonds", 2),
            new Card("4 of Diamonds", "Diamonds", 3),
            new Card("5 of Diamonds", "Diamonds", 4),
            new Card("6 of Diamonds", "Diamonds", 5),
            new Card("7 of Diamonds", "Diamonds", 6),
            new Card("8 of Diamonds", "Diamonds", 7),
            new Card("9 of Diamonds", "Diamonds", 8),
            new Card("10 of Diamonds", "Diamonds", 9),
            new Card("Jack of Diamonds", "Diamonds", 10),
            new Card("Queen of Diamonds", "Diamonds", 11),
            new Card("King of Diamonds", "Diamonds", 12),
            new Card("Ace of Diamonds", "Diamonds", 13),
             new Card("2 of Hearts", "Hearts", 1),
            new Card("3 of Hearts", "Hearts", 2),
            new Card("4 of Hearts", "Hearts", 3),
            new Card("5 of Hearts", "Hearts", 4),
            new Card("6 of Hearts", "Hearts", 5),
            new Card("7 of Hearts", "Hearts", 6),
            new Card("8 of Hearts", "Hearts", 7),
            new Card("9 of Hearts", "Hearts", 8),
            new Card("10 of Hearts", "Hearts", 9),
            new Card("Jack of Hearts", "Hearts", 10),
            new Card("Queen of Hearts", "Hearts", 11),
            new Card("King of Hearts", "Hearts", 12),
            new Card("Ace of Hearts", "Hearts", 13)
            #endregion
        };

        private Random _rand = new Random();

        public int Round { get; set; }

        private Card[] _seatOnePassing;
        private Card[] _seatTwoPassing;
        private Card[] _seatThreePassing;
        private Card[] _seatFourPassing;

        //public Card[] Trick;

        public List<Card> Shuffle(Card[] _startingDeck)
        {
            List<Card> tempDeck = new List<Card>(52);

            foreach(Card card in startingDeck)
            {
                tempDeck.Add(card);
            }

            return tempDeck;
        }

        public Card[] ShuffleStep1()
        {
            // Knuth shuffle algorithm :: courtesy of Wikipedia :)
            for(int i = 0; i < startingDeck.Length; i++)
            {
                Card tmp = startingDeck[i];
                int r = _rand.Next(i, startingDeck.Length);
                startingDeck[i] = startingDeck[r];
                startingDeck[r] = tmp;
                i++;
            }

            return startingDeck;
        }

        public void Deal(List<Card> deck, Player player, Opponent Op1, Opponent Op2, Opponent Op3)
        {

            //int card = 0;

            ////i increases by four so we can work with all hands at once
            //for (int i = 0; i < (deck.Length - 3); i += 4)
            //{
            //    try
            //    {
            //        player.Hand[card] = deck[i];

            //        Op1.Hand[card] = deck[i + 1];

            //        Op2.Hand[card] = deck[i + 2];

            //        Op3.Hand[card] = deck[i + 3];

            //        card++;
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine("Something is very Bad" + ex.Message);
            //    }
            //}
        }

        public void SwapCards(Player player, Card[] one, Opponent OP1, Card[] two, Opponent Op2, Card[] three, Opponent Op3, Card[] four)
        {
            //Card[] placeHolder;
            //_seatOnePassing = one;
            //_seatTwoPassing = two;
            //_seatThreePassing = three;
            //_seatFourPassing = four;

            ////Passes to the left if it is a left round
            //if (new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41 }.Contains(Round))
            //{
            //    placeHolder = _seatOnePassing;
            //    _seatOnePassing = _seatFourPassing;
            //    _seatFourPassing = _seatThreePassing;
            //    _seatThreePassing = _seatTwoPassing;
            //    _seatTwoPassing = placeHolder;
            //}
            ////Passes to the right if it is a right round
            //else if (new int[] { 2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42 }.Contains(Round))
            //{
            //    placeHolder = _seatOnePassing;
            //    _seatOnePassing = _seatTwoPassing;
            //    _seatTwoPassing = _seatThreePassing;
            //    _seatThreePassing = _seatFourPassing;
            //    _seatFourPassing = placeHolder;
            //}
            ////Passes across if it is an across round
            //else if (new int[] { 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43 }.Contains(Round))
            //{
            //    placeHolder = _seatOnePassing;
            //    _seatOnePassing = _seatThreePassing;
            //    _seatThreePassing = placeHolder;
            //    placeHolder = _seatTwoPassing;
            //    _seatTwoPassing = _seatFourPassing;
            //    _seatFourPassing = placeHolder;
            //}
            ////They do not pass every fourth round
            //else
            //{
            //    Console.WriteLine("GameManager.PassCards: Did not successfully pass cards");
            //}

            //if(_seatOnePassing == null || _seatTwoPassing == null || _seatThreePassing == null || _seatFourPassing == null)
            //{
            //    Console.WriteLine(_seatOnePassing);
            //    Console.WriteLine(_seatTwoPassing);
            //    Console.WriteLine(_seatThreePassing);
            //    Console.WriteLine(_seatFourPassing);
            //}
            //player.PassedCards = _seatOnePassing;
            //OP1.PassedCards = _seatTwoPassing;
            //Op2.PassedCards = _seatThreePassing;
            //Op3.PassedCards = _seatFourPassing;
        }

        //public BasePlayer Trick(BasePlayer player, BasePlayer Op1, BasePlayer Op2, BasePlayer Op3)
        //{

        //}

        /*
                public void PrintCardNames()
                {
                    foreach (Card card in startingDeck)
                    {
                        Console.WriteLine(card.Name);
                    }
                }
        */
    }
}
