using System;

namespace ex25_poo
{
    public class Player : Character
    {
        // Construtor da classe Player, que usa a base de name da classe 
        // abstrata Character
        public Player(string name) : base(name) { }

        // Override do método abstrato Move() da classe abstrata Character,
        // pede ao jogador um input (WASD) e retorna um char que representa
        // a direção do jogador
        public override char Move()
        {
            // Delcarar variáveis
            char mInput;

            // Pedir input ao jogador (WASD)
            Console.WriteLine("What direction will you move in?\n" +
                "(W - North, A - West, S - South, D - East\n");

            // Guardar o input do jogador na variável mInput, para ser usada
            // na determinação da direção do movimento
            mInput = Console.ReadLine().ToUpper()[0];

            // Switch case que determina o char devolvido pela função de acordo
            // com o input do jogador
            switch (mInput)
            {
                case 'W': return 'N';
                case 'A': return 'W';
                case 'S': return 'S';
                case 'D': return 'E';
                default: return '?';
            }
        }

        // Override do método ToString() para imprimir o nome dado à instância
        // da Classe Player através do construtor
        public override string ToString() => $"Player Name: {Name}";
    }
}
