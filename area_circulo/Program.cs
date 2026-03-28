using System;

namespace area_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            
            Console.WriteLine("Digite o valor do diâmetro: ");
            d = double.Parse(Console.ReadLine());

            double r = d/2;
            
            Console.WriteLine("A área do circulo é {0}",(3.14*(r*r)));
            
            Console.ReadLine(); 
        }
    }
}