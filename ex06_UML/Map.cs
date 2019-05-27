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
        public Map(string mapName, string filename, int numberOfPlayers)
        {
            players = new List<Player>();
            Name = mapName;
            Filename = filename;
            // Instancia Players, de número igual à variável numberOfPlayers
            // dada, pedindo os parâmetros necessários para a instanciação
            for (int id = 0; id < numberOfPlayers; id++)
            {
                Console.WriteLine("Insert player's name:");
                string playerName = Console.ReadLine();
                players.Add(new Player(id, playerName, 100.0, 100.0));
            }
        }

        public override string ToString() => $"Name: {Name}\nFilename: " +
            $"{Filename}\nNumber of Players: {players.Count}\n";
    }
}
