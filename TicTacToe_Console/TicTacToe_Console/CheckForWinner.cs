using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public class CheckForWinner
    {
        public Player Check(Board board, Player player)
        {
            string W = player.Weapon;
            if (
                //Horizontal
                (W == board.spaces[1] && W == board.spaces[2] && W == board.spaces[3]) ||
                (W == board.spaces[4] && W == board.spaces[5] && W == board.spaces[6]) ||
                (W == board.spaces[7] && W == board.spaces[8] && W == board.spaces[9]) ||

                //Vertical
                (W == board.spaces[1] && W == board.spaces[4] && W == board.spaces[7]) ||
                (W == board.spaces[2] && W == board.spaces[5] && W == board.spaces[8]) ||
                (W == board.spaces[3] && W == board.spaces[6] && W == board.spaces[9]) ||

                //Diagonal
                (W == board.spaces[1] && W == board.spaces[5] && W == board.spaces[9]) ||
                (W == board.spaces[3] && W == board.spaces[5] && W == board.spaces[7])
                )
                {
                player.Won = true;
            }

            return player;
        }
    }
}
