using System;
using System.Collections.Generic;
using System.Text;

namespace ex07_UML
{
    class OpenWorldMap : Map
    {
        public float Width { get; }
        public float Height { get; }

        public OpenWorldMap(string Name, string Filename, int numberOfPlayers,
            float width, float height) : base(Name, Filename, numberOfPlayers)
        {
            Width = width;
            Height = height;
        }

        public override string ToString() => $"Name: {Name}\nFilename: " +
            $"{Filename}\nNumber of Players: {players.Count}\n" +
            $"Width: {Width}\nHeight: {Height}";
    }
}
