using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{

    public static class LaunchGame
    {
        static Messages messages = new Messages();

        public static void Launch()
        {
            Player player1 = new Player();
            Player player2 = new Player();

            messages.Intro();

            //Recieve player 1's name
            Console.WriteLine("Player 1, please enter your name:\n");
            player1.Name = Console.ReadLine();
            Console.WriteLine("Hey, " + player1.Name + "! Welcome to the game.");
            Console.ReadLine();
            
            //Recieve player 2's name
            Console.WriteLine("Player 2, please enter your name: \n");
            player2.Name = Console.ReadLine();
            Console.WriteLine("Welcome to the game, " + player2.Name + "! \n\n");
            Console.ReadLine();

            Console.WriteLine("AAAAAAAAAALRIIIIIIIIIIIGHT, LET'S BEGIN!");
                Console.Read();

            Game.Run(player1, player2);


        }

    }
}
