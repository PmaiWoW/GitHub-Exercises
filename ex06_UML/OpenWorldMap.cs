namespace ex06_UML
{
    public class OpenWorldMap : Map
    {
        public float Width { get; }
        public float Height { get; }

        public OpenWorldMap(string name, string filename, int numberOfPlayers,
            float width, float height) : base(name, filename, numberOfPlayers)
        {
            Width = width;
            Height = height;
        }

        public override string ToString() => $"Name: {Name}\nFilename: " +
            $"{Filename}\nNumber of Players: {players.Count}\n" +
            $"Width: {Width}\nHeight: {Height}";
    }
}
