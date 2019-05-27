namespace ex06_UML
{
    public class DungeonMap : Map
    {
        public int NumberOfDungeons { get; set; }

        public DungeonMap(string Name, string Filename, int numberOfPlayers,
            int numberOfDungeons) : base(Name, Filename, numberOfPlayers)
        {
            NumberOfDungeons = numberOfDungeons;
        }

        public override string ToString() => $"Name: {Name}\nFilename: " +
            $"{Filename}\nNumber of Players: {players.Count}" +
            $"\nNumber of Dungeons: {NumberOfDungeons}\n";
    }
}
