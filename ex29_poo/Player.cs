using System;
using System.Collections.Generic;
using System.Text;

namespace ex29_poo
{
    public class Player
    {
        // Declarar variáveis
        // Variável de Instância readonly
        private readonly string name;
        // Variável de Classe dialogue, readonly
        private static readonly string dialogue = "I'll take a look at your " +
            "wares";

        // Propriedade de Classe Age, só de leitura, de valor 25
        private static int Age { get; } = 25;
        // Propriedade readonly, pois apenas tem método get
        private int MoveOrder { get; }

        // Construtor da Classe Player
        public Player(string name, int moveOrder)
        {
            // Instanciar variável name através da variável dada ao construtor
            this.name = name;
            // Instanciar propriedade MoveOrder através da variável dada ao 
            // construtor
            this.MoveOrder = moveOrder;
        }

        // Override do método ToString(), usado para confirmar que a instância
        // possui todas as variáveis e propriedades de instãncia e de classe
        public override string ToString() => $"Name: {name}\nAge: {Age}\n" +
            $"Voice Line: {dialogue}\nMove Order: {MoveOrder}";
    }
}
