namespace ex06_UML
{
    public class Player
    {
        public int ID { get; }
        public string Name { get; }
        private double health;
        private double shield;

        public Player(int id, string name, double health, double shield)
        {
            ID = id;
            Name = name;
            this.health = health;
            this.shield = shield;
        }
    }
}
