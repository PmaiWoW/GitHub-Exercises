using System;
using System.Collections.Generic;

namespace ex06_UML
{
    internal class Program
    {
        List<Player> players;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            players = new List<Player>();
            Game game = new Game();
            game.GameLoop();

            Console.WriteLine($"Number of Games Played: {game.gamesPlayed}");
        }
    }
}