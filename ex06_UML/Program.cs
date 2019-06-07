using System;

namespace ex06_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameLoop();
            
            Console.WriteLine($"\nNumber of Games Played: {Game.gamesPlayed}");
        }
    }
}