using System;
using System.Collections.Generic;

namespace ex06_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameLoop();

            Console.WriteLine($"Number of Games Played: {game.gamesPlayed}");
        }
        
    }
}