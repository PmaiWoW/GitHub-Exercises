using System;

namespace ex83_poo
{
    using System;

    public class NPC
    {
        public float HP { get; private set; }

        public NPC(float hp) { HP = hp; }

        public void TakeHit(float damage)
        {
            HP -= damage;
            if (HP < 0) HP = 0;
        }
    }

    public class Program
    {
        public static void Main()
        {
            NPC[] npcs = new NPC[]
            {
                new NPC(12.5f),
                new NPC(19.5f)
            };

            ref NPC npc1 = ref npcs[0];
            npc1.TakeHit(5f);
            
            foreach(NPC npc in npcs)
            {
                Console.WriteLine($"HP={npc.HP}");
            }
        }
    }
}
