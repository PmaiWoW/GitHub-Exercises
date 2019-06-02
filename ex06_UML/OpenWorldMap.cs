using System.Collections.Generic;

namespace ex06_UML
{
    public class OpenWorldMap : Map
    {
        public float Width { get; }
        public float Height { get; }

        public OpenWorldMap(string name, string filename, List<Player> players,
            float width, float height) : base(name, filename, players)
        {
            Width = width;
            Height = height;
        }

        public override string ToString() => base.ToString() + $"Width: " +
            $"{Width}\nHeight: {Height}";
    }
}
