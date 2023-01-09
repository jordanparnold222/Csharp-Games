using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public static class Round
    {
        static Messages messages = new Messages();
        static CheckForWinner checkForWinner = new CheckForWinner();
        public static (Player, Board, bool) Run(Player player, Board board, bool p1Turn)
        {

            messages.CurrentBoard(board);

            bool hasChosen = false;
            while (!hasChosen)
            {
                Console.WriteLine(player.Name + " enter your selection");
                int selection = int.Parse(Console.ReadLine());
                if ((selection).ToString() == board.spaces[selection])
                {
                    board.spaces[selection] = player.Weapon;
                    checkForWinner.Check(board, player);
                    p1Turn = !p1Turn;
                    hasChosen = true;
                }

                else
                {
                    Console.WriteLine("This space has already been used. Please make another selecton.");
                }

            }

            return (player, board, p1Turn);

        }
    }
}
