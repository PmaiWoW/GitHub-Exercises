using System;

namespace ex25_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Archibald Longpants");
            NPC npc1 = new NPC("Bongitard Archlong");

            bool loop = true;

            while (loop)
            {
                Console.WriteLine($"Player Move Direction: {p1.Move()}");
                Console.WriteLine($"NPC Move Direction: {npc1.Move()}");
            }
        }
    }
}
