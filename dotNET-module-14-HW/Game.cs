using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_14_HW
{

    public class Game
    {
        private Deck deck = new Deck();
        private Player player1 = new Player();
        private Player player2 = new Player();
        private Players who_activ;
        private Players who_turn;
        private bool ImpossibleTurn;

        public Game()
        {
            ImpossibleTurn = false;
            who_turn = Players.play1;
            who_activ = Players.play1;
            for (int i = 0; i < 6; i++)
            {
                player1.AddCard(deck.GetCardTop());
                deck.DeleteCardTop();
                player2.AddCard(deck.GetCardTop());
                deck.DeleteCardTop();
            }
        }

        public void Turn()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            // Implement Turn logic similar to the C++ version
            // ...

            if (who_turn == Players.play1)
                who_turn = Players.play2;
            else
                who_turn = Players.play1;
        }

        public void Display()
        {
            Console.Clear();
            // Implement Display logic similar to the C++ version
            // ...
        }
    }
}
