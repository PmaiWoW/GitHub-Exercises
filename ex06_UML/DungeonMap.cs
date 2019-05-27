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

        public override string ToString() => $"Name: {Name}\nFilename: " +
            $"{Filename}\nNumber of Players: {players.Count}" +
            $"\nNumber of Dungeons: {NumberOfDungeons}\n";
    }
}
