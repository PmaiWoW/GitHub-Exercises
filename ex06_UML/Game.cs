using System;

namespace ex06_UML
{
    public class Game
    {
        internal int gamesPlayed;
        private int numberOfPlayers;
        private Map dngMap, opnWrldMap, dngMap2, opnWrldMap2;

        internal void GameLoop()
        {
            gamesPlayed = 0;

            // Pede ao utilizador o número de jogadores
            Console.WriteLine("\nCreate Dungeon Map\nHow many players will " +
                "spawn?");
            // Converte o input para int e guarda o mesmo na variável de 
            // mesmo tipo numberOfPlayers
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            // Instanciar um objeto da classe DungeonMap, guardado numa
            // variável de tipo Map
            dngMap = new DungeonMap("Dungeon", "dng.PNG", 
                numberOfPlayers, 5);
            // ToString() da classe DungeonMap
            Console.WriteLine($"\n{dngMap}");
            // Imprimir os nomes dos jogadores neste mapa
            dngMap.PrintPlayerNames();
            // Aumentar o número de jogos jogados
            gamesPlayed++;

            // Pede ao utilizador o número de jogadores
            Console.WriteLine("\nCreate Open World Map\nHow many players " +
                "will spawn?");
            // Converte o input para int e guarda o mesmo na variável de 
            // mesmo tipo numberOfPlayers
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            // Instanciar um objeto da classe OpenWorldMap, guardado numa
            // variável de tipo Map
            opnWrldMap = new OpenWorldMap("openWrld",
                "opnWrld.PNG", numberOfPlayers, 100.0f, 150.0f);
            // ToString() da classe OpenWorldMap
            Console.WriteLine($"\n{opnWrldMap}\n");
            // Imprimir os nomes dos jogadores neste mapa
            opnWrldMap.PrintPlayerNames();
            // Aumentar o número de jogos jogados
            gamesPlayed++;

            // Pede ao utilizador o número de jogadores
            Console.WriteLine("\nCreate Dungeon Map\nHow many players will " +
                "spawn?");
            // Converte o input para int e guarda o mesmo na variável de 
            // mesmo tipo numberOfPlayers
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            // Instanciar um objeto da classe DungeonMap, guardado numa
            // variável de tipo Map
            dngMap2 = new DungeonMap("Dungeon2", "dng2.PNG", 
                numberOfPlayers, 5);
            // ToString() da classe DungeonMap
            Console.WriteLine($"\n{dngMap2}\n");
            // Imprimir os nomes dos jogadores neste mapa
            dngMap2.PrintPlayerNames();
            // Aumentar o número de jogos jogados
            gamesPlayed++;

            // Pede ao utilizador o número de jogadores
            Console.WriteLine("\nCreate Open World Map\nHow many players " +
                "will spawn?");
            // Converte o input para int e guarda o mesmo na variável de 
            // mesmo tipo numberOfPlayers
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            // Instanciar um objeto da classe OpenWorldMap, guardado numa
            // variável de tipo Map
            opnWrldMap2 = new OpenWorldMap("openWrld2",
                "opnWrld2.PNG", numberOfPlayers, 100.0f, 150.0f);
            // ToString() da classe OpenWorldMap
            Console.WriteLine($"\n{opnWrldMap2}\n");
            // Imprimir os nomes dos jogadores neste mapa
            opnWrldMap.PrintPlayerNames();
            // Aumentar o número de jogos jogados
            gamesPlayed++;
        }
    }
}
