using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;

            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            c =double.Parse(Console.ReadLine());

            Console.WriteLine("A temperatura em Fahrenheit é {0} graus Fahrenheit", (c*1.9)+32);
            Console.ReadLine(); 
        }
    }
}