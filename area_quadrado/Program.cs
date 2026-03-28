using System;

namespace area_quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite o comprimento de uma aresta do quadrado: ");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("A área do quadrado é {0}", a*a);
            Console.ReadLine(); 
        }
    }
}