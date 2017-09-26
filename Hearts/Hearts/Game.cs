using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    class Game
    {
        


        //public void StartGame()
        //{
        //    List<Card> Deck = _game.Shuffle();

        //    List<BasePlayer> players = new List<BasePlayer>()
        //    {
        //        player,
        //        Op1,
        //        Op2,
        //        Op3
        //    };

        //    _game.Round = 1;

        //    _game.Deal(Deck, player, Op1, Op2, Op3);

        //    player.PassCards();
        //    Op1.PassCards();
        //    Op2.PassCards();
        //    Op3.PassCards();

        //    Console.WriteLine();
        //    Console.WriteLine("Your passed cards are: ");
        //    foreach (Card card in player.PassedCards)
        //    {
        //     if (card == null)
        //    {
        //     break;
        //     }

        //    Console.WriteLine(card.Name + ", ");
        //    }

        //    Console.WriteLine();

        //    _game.SwapCards(player, player.PassedCards, Op1, Op1.PassedCards, Op2, Op2.PassedCards, Op3, Op3.PassedCards);

        //    player.InsertReceivedCards();
        //    Op1.InsertReceivedCards();
        //    Op2.InsertReceivedCards();
        //    Op3.InsertReceivedCards();

        //    player.IsLeading = player.WhoStarts(player.Hand);
        //    Op1.IsLeading = Op1.WhoStarts(Op1.Hand);
        //    Op2.IsLeading = Op2.WhoStarts(Op2.Hand);
        //    Op3.IsLeading = Op3.WhoStarts(Op3.Hand);

        //    Console.WriteLine();
        //    player.PrintHand();
        //    Op1.PrintHand();
        //    Op2.PrintHand();
        //    Op3.PrintHand();

        //    Console.WriteLine(player.IsLeading);
        //    Console.WriteLine(Op1.IsLeading);
        //    Console.WriteLine(Op2.IsLeading);
        //    Console.WriteLine(Op3.IsLeading);

        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();

        //    Card testCard = player.PlayCard("Spades");

        //    Console.WriteLine(testCard.Name);

        //    Console.ReadKey();

        //}

        //public void TestGame()
        //{
        //    List<Card> Deck = _game.Shuffle();

        //    BasePlayer[] players =
        //    {
        //        player,
        //        Op1,
        //        Op2,
        //        Op3
        //    };

        //    _game.Round = 1;

        //    _game.Deal(Deck, player, Op1, Op2, Op3);

        //    player.PassCards();
        //    Op1.PassCards();
        //    Op2.PassCards();
        //    Op3.PassCards();

        //    Op1.PrintHand();

        //    Console.WriteLine(Op1.PlayCard("Spades").Name);

        //    Console.ReadKey();


        //}
    }
}