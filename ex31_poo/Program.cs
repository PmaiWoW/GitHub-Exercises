using System;

namespace ex31_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pergunta 2
            PowerUp armorPack = new PowerUp();
            armorPack.Tag = "CRL";
            Console.WriteLine(armorPack);
            armorPack.Tag = "Armor+75";
            Console.WriteLine(armorPack);

            // Instrução 1
            // Esta instrução é válida, pois o construtor da classe PowerUp não
            // requer qualquer argumento e não possui modificadores de herança;
            PowerUp pu = new PowerUp();

            // Instrução 2
            // Esta instrução é inválida, pois a classe GameObject com o 
            // modificador de herança abstract, impedindo-a de ser instanciada;
            GameObject go = new GameObject();

            // Instrução 3
            // Esta instrução é válida, pois, tal como a instrução 1, o
            // construtor da classe Trap não requer qualquer argumento e não
            // possui modificadores de herança;
            Trap t = new Trap();

            // Instrução 4
            // Esta instrução é inválida, pois não é possível instanciar uma 
            // interface;
            ITaggable it = new ITaggable();

            // Instrução 5
            // Instrução 5: Esta instrução é inválida, pois a classe 
            // GameObject não possui o método `DisableTrap()`, apenas a  classe
            // Trap;
            go.DisableTrap(); // go é uma variável do tipo GameObject

            // Instrução 6
            // Esta instrução é inválida, pois, tal como a instrução 2, a 
            // declaração da classe `GameObject` tem o modificador de herança 
            // `abstract`, impedindo-a de ser instanciada;
            PowerUp armorPacko = new GameObject();

            // Instrução 7
            // Esta instrução é inválida, pois tenta converter o método
            // DisableTrap() da classe Trap para tipo inteiro, o que é 
            // impossível;
            Trap gobj = new Trap();
            int p = gobj.DisableTrap; // gobj é do tipo Trap

            //Instrução 8
            // Esta instrução é inválida, pois a interface ITaggable não é
            // implementada na classe Trap, logo uma instância desta classe não
            // pode ter uma tag como variável;
            Trap trap = new Trap();
            Console.WriteLine($"{trap.Tag}"); // trap é uma instância de Trap

            // Instrução 9
            // Esta instrução é válida, pois a classe Trap é uma subclasse da
            // classe GameObject, que é a superclasse, logo podemos ter uma
            // instância da classe Trap do tipo GameObject, mas não o contrário
            // como podemos observar nas instruções 2 e 6;
            GameObject go2 = new Trap();

            // Instrução 10
            // Esta instrução é válida, pois, tal como na instrução 9, a classe
            // PowerUp é uma subclasse da classe GameObject, que é a 
            // superclasse, logo podemos ter uma instância da classe PowerUp do
            // tipo GameObject, mas não o contrário como podemos observar nas 
            // instruções 2 e 6;
            GameObject go3 = new PowerUp();

            // Instrução 11
            // Esta instrução é válida, pois a classe PowerUp tem o método
            // Priority, herdado da superclasse GameObject e sobreposto
            // para retornar o valor do comprimento da Tag, podendo usar a Tag
            // pois implementa a interface ITaggable;
            PowerUp pup = new PowerUp();
            Console.WriteLine($"{pup.Priority()}");// pup: instância de PowerUp
        }
    }
}
