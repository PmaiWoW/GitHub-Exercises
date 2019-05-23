using System;

namespace ex24_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto de tipo Car, guardado num variável de tipo
            // Vehicle
            Vehicle teslaRoadster = new Car(2550.0, 3, 70.0f);

            Car teslaRoadster2 = new Car(2550.0, 3, 70.0f);

            Console.WriteLine(teslaRoadster2.GetTotalWeight(teslaRoadster2));
        }
    }
}
