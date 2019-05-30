namespace ex06_UML
{
    public class DungeonMap : Map
    {
        public int NumberOfDungeons { get; set; }

        public DungeonMap(string name, string filename, int numberOfPlayers,
            int numberOfDungeons) : base(name, filename, numberOfPlayers)
        {
            NumberOfDungeons = numberOfDungeons;
        }

        public override string ToString() => base.ToString() + $"Number of " +
            $"Dungeons: {NumberOfDungeons}\n";
    }
}
