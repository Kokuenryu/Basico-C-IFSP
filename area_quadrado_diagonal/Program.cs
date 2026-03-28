using System;

namespace area_quadrado_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;

            Console.WriteLine("Digite o valor da diagonal do quadrado: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("A área do quadrado é {0}", (d*d)/2);
            Console.ReadLine(); 
        }
    }
}