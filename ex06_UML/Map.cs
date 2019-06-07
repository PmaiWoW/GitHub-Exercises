using System;
using System.Collections.Generic;
using System.Linq;

namespace ex06_UML
{
    public abstract class Map
    {
        // Declarar Variáveis
        public string Name { get; }
        protected string Filename { get; }
        protected ICollection<Player> players;

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

            foreach(Player p in players)
            {
                Console.WriteLine($"Player Name: {p.Name}");
            }
        }
    }
}
