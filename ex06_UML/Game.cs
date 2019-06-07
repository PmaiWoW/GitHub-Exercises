using System;
using System.Collections.Generic;

namespace ex06_UML
{
    public class Game
    {
        static internal int gamesPlayed;
        private int numberOfPlayers;
        private Map currentMap;

        internal void GameLoop()
        {
            gamesPlayed = 0;
            List<Player> players = new List<Player>();


            players = new List<Player>();
            {
                // Pede ao utilizador o número de jogadores
                Console.WriteLine("\nCreate Dungeon Map\nHow many players " +
                    "will spawn?");
                // Converte o input para int e guarda o mesmo na variável de 
                // mesmo tipo numberOfPlayers
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                // Instancia Players, de número igual à variável numberOfPlayers
                // dada, pedindo os parâmetros necessários para a instanciação
                for (int id = 0; id < numberOfPlayers; id++)
                {
                    Console.WriteLine("Insert player's name:");
                    string playerName = Console.ReadLine();
                    players.Add(new Player(id, playerName, 100.0, 100.0));
                }
            }
            // Instanciar um objeto da classe DungeonMap, guardado numa
            // variável de tipo Map
            currentMap = new DungeonMap("Dungeon", "dng.PNG", 
                players, 5);
            // ToString() da classe DungeonMap
            Console.WriteLine($"\n{currentMap}");
            // Imprimir os nomes dos jogadores neste mapa
            currentMap.PrintPlayerNames();
            // Aumentar o número de jogos jogados
            gamesPlayed++;


            players = new List<Player>();
            {
                // Pede ao utilizador o número de jogadores
                Console.WriteLine("\nCreate Dungeon Map\nHow many players " +
                    "will spawn?");
                // Converte o input para int e guarda o mesmo na variável de 
                // mesmo tipo numberOfPlayers
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                // Instancia Players, de número igual à variável numberOfPlayers
                // dada, pedindo os parâmetros necessários para a instanciação
                for (int id = 0; id < numberOfPlayers; id++)
                {
                    Console.WriteLine("Insert player's name:");
                    string playerName = Console.ReadLine();
                    players.Add(new Player(id, playerName, 100.0, 100.0));
                }
            }
            // Instanciar um objeto da classe OpenWorldMap, guardado numa
            // variável de tipo Map
            currentMap = new OpenWorldMap("openWrld",
                "opnWrld.PNG", players, 100.0f, 150.0f);
            // ToString() da classe OpenWorldMap
            Console.WriteLine($"\n{currentMap}\n");
            // Imprimir os nomes dos jogadores neste mapa
            currentMap.PrintPlayerNames();
            // Aumentar o número de jogos jogados
            gamesPlayed++;


            players = new List<Player>();
            {
                // Pede ao utilizador o número de jogadores
                Console.WriteLine("\nCreate Dungeon Map\nHow many players " +
                    "will spawn?");
                // Converte o input para int e guarda o mesmo na variável de 
                // mesmo tipo numberOfPlayers
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                // Instancia Players, de número igual à variável numberOfPlayers
                // dada, pedindo os parâmetros necessários para a instanciação
                for (int id = 0; id < numberOfPlayers; id++)
                {
                    Console.WriteLine("Insert player's name:");
                    string playerName = Console.ReadLine();
                    players.Add(new Player(id, playerName, 100.0, 100.0));
                }
            }
            // Instanciar um objeto da classe DungeonMap, guardado numa
            // variável de tipo Map
            currentMap = new DungeonMap("Dungeon2", "dng2.PNG", 
                players, 5);
            // ToString() da classe DungeonMap
            Console.WriteLine($"\n{currentMap}\n");
            // Imprimir os nomes dos jogadores neste mapa
            currentMap.PrintPlayerNames();
            // Aumentar o número de jogos jogados
            gamesPlayed++;


            players = new List<Player>();
            {
                // Pede ao utilizador o número de jogadores
                Console.WriteLine("\nCreate Dungeon Map\nHow many players " +
                    "will spawn?");
                // Converte o input para int e guarda o mesmo na variável de 
                // mesmo tipo numberOfPlayers
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                // Instancia Players, de número igual à variável numberOfPlayers
                // dada, pedindo os parâmetros necessários para a instanciação
                for (int id = 0; id < numberOfPlayers; id++)
                {
                    Console.WriteLine("Insert player's name:");
                    string playerName = Console.ReadLine();
                    players.Add(new Player(id, playerName, 100.0, 100.0));
                }
            }
            // Instanciar um objeto da classe OpenWorldMap, guardado numa
            // variável de tipo Map
            currentMap = new OpenWorldMap("openWrld2",
                "opnWrld2.PNG", players, 100.0f, 150.0f);
            // ToString() da classe OpenWorldMap
            Console.WriteLine($"\n{currentMap}\n");
            // Imprimir os nomes dos jogadores neste mapa
            currentMap.PrintPlayerNames();
            // Aumentar o número de jogos jogados
            gamesPlayed++;
        }
    }
}
