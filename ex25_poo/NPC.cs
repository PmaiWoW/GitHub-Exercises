using System;
using System.Collections.Generic;
using System.Text;

namespace ex25_poo
{
    public class NPC : Character
    {
        // Declarar variáveis
        private Random rnd;
        // string apenas de leitura que contém os carácteres das direções
        private readonly string directions;

        // Construtor da classe NPC, que usa a base de name da classe 
        // abstrata Character
        public NPC(string name) : base(name)
        {
            rnd = new Random();
            directions = "NSWE";
        }

        // Override do método abstrato Move() da classe abstrata Character,
        // determina aleatoriamente através do Random rnd declarado o carácter
        // da string directions a ser usado para determinar a direção do
        // movimento do NPC
        public override char Move() => directions[rnd.Next(directions.Length)];
    }
}
