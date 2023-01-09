using TicTacToe_Console;


Console.WriteLine("Pssst... You tryna play some Tic Taco Toe...?");
string answer = Console.ReadLine().ToLower();
if (answer == "yes" || answer == "ya" || answer == "yeah")
{
    LaunchGame.Launch();
}
else
{
    Console.WriteLine("Okay, goodbye");
}

