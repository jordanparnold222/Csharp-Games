using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public static class Game
    {
        public static Messages messages = new Messages();


        public static void Run(Player p1, Player p2)
        {
            p1.Weapon = "X";
            p2.Weapon = "O";

            Console.WriteLine("Here are the rules: \n");
            Console.WriteLine(p1.Name + " is X's.\n" + p2.Name + " is O's.");
            Console.WriteLine("On the board, each unoccupied space with have a number in it. \n" +
                "Whoever's turn it is, that player will enter their space selection, \nhit the 'Enter' key, \nthen it becomes the other player's turn. \n\n" +
                "First player to connect 3 spaces with their weapon, WINS!");
            Console.ReadLine();

            //Rounds begin
            Board board = new Board();
            bool p1Turn = true;
            int BoardCount = 1;

            while ((p1.Won == false) && (p2.Won == false))
            {
                if (p1Turn == true)
                { Round.Run(p1, board, p1Turn);
                  p1Turn = false;
                    BoardCount++;
                    Console.WriteLine("~~~~~~~~~~\n~~~~~~~~~~\n~~~~~~~~~~\n~~~~~~~~~~\n~~~~~~~~~~\n");

                }
                else
                {
                    Round.Run(p2, board, p1Turn);
                    p1Turn = true;
                    BoardCount++;
                    Console.WriteLine("~~~~~~~~~~\n~~~~~~~~~~\n~~~~~~~~~~\n~~~~~~~~~~\n~~~~~~~~~~\n");
                }
            }

            if (p1.Won == true) Console.WriteLine(p1.Name + " WINS!!!!!!! \nThere is no trophy, but you can put this on your resume or whatever.");
            else if (p2.Won == true) Console.WriteLine(p2.Name + " WINS!!!!!!! \nThere is no trophy, but you can put this on your resume or whatever.");
        }
    }
}
