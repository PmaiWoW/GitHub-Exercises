﻿using System;

namespace ex23_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar variável de tipo Weapon que guarda uma instância de
            // Gun com value = 50.0f, bullets = 16 e calibre = 0.357f;
            Weapon gun = new Gun(50.0f, 3, 0.5f);

            Gun gun2 = new Gun(600.0f, 45, 0.44f);

            Console.WriteLine($"Number of bullets: {gun2.NumberOfBullets}");

            // Código "teste" para UML para verificação da criação de 
            // instâncias da Classe Bullet fora de uma instância da Classe Gun
            // Declaração de instância de objeto de Classe Bullet guardado numa 
            // Variável tipo Bullet
            Bullet bullet1 = new Bullet() { Calibre = 0.44f };

            Console.WriteLine(bullet1.Calibre);
        }
    }
}
