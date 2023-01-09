using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public class Messages
    {
        //Intro message
        public void Intro()
        {
            Console.WriteLine("WELCOME TO");
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("~~~~~~~~~~~~~~~~~");





            Console.WriteLine("by Jordan Arnold");
            Console.WriteLine("\n(I didn't invent the game) \nPress \"Enter\" to begin this A M A Z I N G game");
            Console.ReadLine();
        }

        //displays current gameboard
        public void CurrentBoard(Board board)
        {
            Console.WriteLine("Current board: \n" +
    board.spaces[1] + "|" + board.spaces[2] + "|" + board.spaces[3] + "\n" +
    board.spaces[4] + "|" + board.spaces[5] + "|" + board.spaces[6] + "\n" +
    board.spaces[7] + "|" + board.spaces[8] + "|" + board.spaces[9]  
    );
        }
    }
}
