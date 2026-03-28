using System;

namespace pow
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int e;
            Console.WriteLine("Digite o valor do número da base: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do número do exponente: ");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} elevado a {1} é igual a: {2}", b, e, Math.Pow(b, e));
            Console.ReadLine(); 
        }
    }
}