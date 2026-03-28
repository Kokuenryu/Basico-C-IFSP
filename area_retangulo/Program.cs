using System;

namespace area_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;

            Console.WriteLine("Digite a largura do retângulo: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo: ");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("A área do retangulo é {0}", b*h);
            Console.ReadLine(); 
        }
    }
}