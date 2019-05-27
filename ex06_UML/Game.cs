using System;

namespace ex06_UML
{
    public class Game
    {
        internal int gamesPlayed;
        private int numberOfPlayers;
        Map dngMap, opnWrldMap, dngMap2, opnWrldMap2;

        internal void GameLoop()
        {
            gamesPlayed = 0;

            Console.WriteLine("Create Dungeon Map\nHow many players to " +
                "spawn?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            dngMap = new DungeonMap("Dungeon", "dng.PNG", 
                numberOfPlayers, 5);
            gamesPlayed++;
            Console.WriteLine($"\n{dngMap}\n");
            
            Console.WriteLine("Create Open World Map\nHow many players to " +
                "spawn?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            opnWrldMap = new OpenWorldMap("openWrld",
                "opnWrld.PNG", numberOfPlayers, 100.0f, 150.0f);
            gamesPlayed++;
            Console.WriteLine($"\n{opnWrldMap}\n");
            
            Console.WriteLine("Create Dungeon Map in Map type variable\nHow " +
                "many players will spawn?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            dngMap2 = new DungeonMap("Dungeon2", "dng2.PNG", 
                numberOfPlayers, 5);
            gamesPlayed++;
            Console.WriteLine($"\n{dngMap2}\n");
            
            Console.WriteLine("Create Open World Map in Map type variable\n" +
                "How many players will spawn?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            opnWrldMap2 = new OpenWorldMap("openWrld2",
                "opnWrld2.PNG", numberOfPlayers, 100.0f, 150.0f);
            gamesPlayed++;
            Console.WriteLine($"\n{opnWrldMap2}\n");
        }
    }
}
