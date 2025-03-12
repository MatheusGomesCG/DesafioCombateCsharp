using System;
using System.Globalization;

namespace DesafioCombate
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int life, atack, def;
           
            Console.WriteLine("Digite os dados do primeiro campeão:");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Vida inicial: ");
            life = int.Parse(Console.ReadLine());
            Console.Write("Ataque: ");
            atack = int.Parse(Console.ReadLine());
            Console.Write("Armadura: ");
            def = int.Parse(Console.ReadLine());
            Champion champOne = new Champion(name, life, atack, def);

            Console.WriteLine();
            Console.WriteLine("Digite os dados do segundo campeão:");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Vida inicial: ");
            life = int.Parse(Console.ReadLine());
            Console.Write("Ataque: ");
            atack = int.Parse(Console.ReadLine());
            Console.Write("Armadura: ");
            def = int.Parse(Console.ReadLine());
            Champion champTwo = new Champion(name, life, atack, def);


            Console.WriteLine();
            Console.Write("Quantos turnos você deseja executar? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= choice; i++)
            {
                Console.WriteLine($"Resultado do turno {i}");
                champOne.TakeDamage(champTwo);
                champTwo.TakeDamage(champOne);
                Console.WriteLine(champOne.Status());
                Console.WriteLine(champTwo.Status());

                if(champOne.Life == 0 || champTwo.Life == 0){
                    Console.WriteLine();
                    break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("FIM DO COMBATE");
        }
    }
}
