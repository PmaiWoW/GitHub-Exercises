using System;

namespace ex06_UML
{
    public class Game
    {
        internal int gamesPlayed = 0;
        private int numberOfPlayers;
        DungeonMap dngMap;
        OpenWorldMap opnWrldMap;
        Map dngMap2, opnWrldMap2;

        internal void GameLoop()
        {
            gamesPlayed = 0;
            // Test code for creating a DungeonMap class instance in a
            // DungeonMap type variable
            Console.WriteLine("Create Dungeon Map\nHow many players to " +
                "spawn?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            dngMap = new DungeonMap("Dungeon", "dng.PNG", 
                numberOfPlayers, 5);
            gamesPlayed++;

            Console.WriteLine($"\n{dngMap}\n");

            // Test code for creating a OpenWorldMap class instance in a
            // OpenWorldMap type variable
            Console.WriteLine("Create Open World Map\nHow many players to " +
                "spawn?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            opnWrldMap = new OpenWorldMap("openWrld",
                "opnWrld.PNG", numberOfPlayers, 100.0f, 150.0f);
            gamesPlayed++;

            Console.WriteLine($"\n{opnWrldMap}\n");

            // Test code for creating a DungeonMap class instance in a
            // Map type variable
            Console.WriteLine("Create Dungeon Map in Map type variable\nHow " +
                "many players will spawn?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            dngMap2 = new DungeonMap("Dungeon2", "dng2.PNG", 
                numberOfPlayers, 5);
            gamesPlayed++;

            Console.WriteLine($"\n{dngMap2}\n");

            // Test code for creating a OpenWorldMap class instance in a
            // Map type variable
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
