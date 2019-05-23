namespace ex25_poo
{
    public abstract class Character
    {
        // Read-Only property for the Character's name
        public string Name { get; }

        public Character(string name)
        {
            Name = name;
        }

        // Abstract method for the character's movement that returns a char 
        // (direction) that can be N, S, W, E
        public abstract char Move();
    }
}
