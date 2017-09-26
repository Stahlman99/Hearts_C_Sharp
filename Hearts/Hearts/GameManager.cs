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
            //Spades
            new Card(Type.Two, Suits.Spades),
            new Card(Type.Three, Suits.Spades),
            new Card(Type.Four, Suits.Spades),
            new Card(Type.Five, Suits.Spades),
            new Card(Type.Six, Suits.Spades),
            new Card(Type.Seven, Suits.Spades),
            new Card(Type.Eight, Suits.Spades),
            new Card(Type.Nine, Suits.Spades),
            new Card(Type.Ten, Suits.Spades),
            new Card(Type.Jack, Suits.Spades),
            new Card(Type.Queen, Suits.Spades),
            new Card(Type.King, Suits.Spades),
            new Card(Type.Ace, Suits.Spades),

            //Clubs
            new Card(Type.Two, Suits.Clubs),
            new Card(Type.Three, Suits.Clubs),
            new Card(Type.Four, Suits.Clubs),
            new Card(Type.Five, Suits.Clubs),
            new Card(Type.Six, Suits.Clubs),
            new Card(Type.Seven, Suits.Clubs),
            new Card(Type.Eight, Suits.Clubs),
            new Card(Type.Nine, Suits.Clubs),
            new Card(Type.Ten, Suits.Clubs),
            new Card(Type.Jack, Suits.Clubs),
            new Card(Type.Queen, Suits.Clubs),
            new Card(Type.King, Suits.Clubs),
            new Card(Type.Ace, Suits.Clubs),

            //Hearts
            new Card(Type.Two, Suits.Hearts),
            new Card(Type.Three, Suits.Hearts),
            new Card(Type.Four, Suits.Hearts),
            new Card(Type.Five, Suits.Hearts),
            new Card(Type.Six, Suits.Hearts),
            new Card(Type.Seven, Suits.Hearts),
            new Card(Type.Eight, Suits.Hearts),
            new Card(Type.Nine, Suits.Hearts),
            new Card(Type.Ten, Suits.Hearts),
            new Card(Type.Jack, Suits.Hearts),
            new Card(Type.Queen, Suits.Hearts),
            new Card(Type.King, Suits.Hearts),
            new Card(Type.Ace, Suits.Hearts),

            //Diamonds
            new Card(Type.Two, Suits.Diamonds),
            new Card(Type.Three, Suits.Diamonds),
            new Card(Type.Four, Suits.Diamonds),
            new Card(Type.Five, Suits.Diamonds),
            new Card(Type.Six, Suits.Diamonds),
            new Card(Type.Seven, Suits.Diamonds),
            new Card(Type.Eight, Suits.Diamonds),
            new Card(Type.Nine, Suits.Diamonds),
            new Card(Type.Ten, Suits.Diamonds),
            new Card(Type.Jack, Suits.Diamonds),
            new Card(Type.Queen, Suits.Diamonds),
            new Card(Type.King, Suits.Diamonds),
            new Card(Type.Ace, Suits.Diamonds)
            #endregion
        };

        private Random _rand = new Random();

        public int Round { get; set; }

        //public Card[] Trick;
        public List<Card> Deck { get; set; }

        public Player Player1 = new Player("Nathan", 1);
        public Opponent Op1 = new Opponent("Opponenent 1", 2);
        public Opponent Op2 = new Opponent("Opponenent 2", 3);
        public Opponent Op3 = new Opponent("Opponenent 3", 4);

        public bool IsBroken = false;

        public void Shuffle()
        {
            Deck = ShuffleStep3(ShuffleStep2(ShuffleStep1()));
        }

        public string DisplayDeck()
        {
            string writeToForm = null;

            foreach (Card card in Deck)
            {
                writeToForm += card.Name + "\r\n";
            }

            return writeToForm;
        }

        private List<Card> ShuffleStep3(Card[] _startingDeck)
        {
            List<Card> tempDeck = new List<Card>(52);

            foreach(Card card in startingDeck)
            {
                tempDeck.Add(card);
            }

            return tempDeck;
        }

        private Card[] ShuffleStep1()
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

        private Card[] ShuffleStep2(Card[] onceShuffled)
        {
            int reverseNum = onceShuffled.Length;

            // Knuth shuffle algorithm :: courtesy of Wikipedia :)
            for (int i = 1; i < onceShuffled.Length; i++)
            {
                Card tmp = onceShuffled[reverseNum - i];
                int r = _rand.Next(reverseNum - i, onceShuffled.Length);
                onceShuffled[reverseNum - i] = onceShuffled[reverseNum - r];
                onceShuffled[reverseNum - r] = tmp;
                i++;
            }

            return startingDeck;
        }

        public void Deal(List<Card> _deck)
        {
            //i increases by four so we can work with all hands at once
            for (int i = 0; i < (_deck.Count() - 3); i += 4)
            {
                try
                {
                    Player1.Hand.Add(_deck[i]);

                    Op1.Hand.Add(_deck[i + 1]);

                    Op1.Hand.Add(_deck[i + 2]);

                    Op1.Hand.Add(_deck[i + 3]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Faulty Deal" + ex.Message);
                }
            }
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
