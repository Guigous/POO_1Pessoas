using System;

namespace Pessoas
{
    class Program
    {


        static void Main(string[] args)

        {
            Pessoas a;
            Pessoas b;

            a = new Pessoas();
            b = new Pessoas();


            //Input Info Usuario
            Console.WriteLine("Nome Da Pessoa 1 :");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Idade da Pessoa 1 :");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome Da Pessoa 2 :");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Idade da Pessoa 2 :");
            b.Idade = int.Parse(Console.ReadLine());


            if (b.Idade > a.Idade)
            {
                Console.WriteLine(b.Nome + " e o(a) mais Velho(a)");

            }
            else
            {
                Console.WriteLine(a.Nome + " e o(a) mais velho(a)");
            }

        }
    }
}
