using System.Collections.Generic;

namespace ex06_UML
{
    public class DungeonMap : Map
    {
        public int NumberOfDungeons { get; set; }

        public DungeonMap(string name, string filename, List<Player> players,
            int numberOfDungeons) : base(name, filename, players)
        {
            NumberOfDungeons = numberOfDungeons;
        }

        public override string ToString() => base.ToString() + $"Number of " +
            $"Dungeons: {NumberOfDungeons}\n";
    }
}
