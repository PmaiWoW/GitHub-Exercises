using System;
using System.Collections.Generic;

namespace ex06_UML
{
    public abstract class Map
    {
        // Declarar Variáveis
        public string Name { get; }
        protected string Filename { get; }
        protected List<Player> players;

        // Construtor da classe Map, com os parâmetros name, filename e
        // numberOfPlayers
        public Map(string name, string filename, List<Player> players)
        {
            this.players = players;
            Name = name;
            Filename = filename;
        }

        public override string ToString() => $"Name: {Name}\nFilename: " +
            $"{Filename}\nNumber of Players: {players.Count}\n";

        public void PrintPlayerNames()
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"Player {i + 1} Name: {players[i].Name}");
            }
        }
    }
}
