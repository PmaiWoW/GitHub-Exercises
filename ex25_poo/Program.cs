using System;

namespace ex25_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar Variáveis
            // Instanciar p1 como uma instância da classe Player, guardado numa
            // variável de classe Player
            Player p1 = new Player("Archibald Longpants");
            // Instanciar npc como uma instância da classe NPC, guardado numa
            // variável de classe NPC
            NPC npc1 = new NPC("Bongitard Archlong");

            // Imprime o retorno override do método ToString() da classe 
            // Player, que imprime o nome dado à instância p1
            Console.WriteLine($"{p1}\n");

            // Declarar variável loop como true
            bool loop = true;

            // while loop que pede e imprime as direções do jogador e npc
            // retornadas pelas suas funções de movimento
            while (loop)
            {
                Console.WriteLine($"Player Move Direction: {p1.Move()}");
                Console.WriteLine($"NPC Move Direction: {npc1.Move()}");
            }
        }
    }
}
