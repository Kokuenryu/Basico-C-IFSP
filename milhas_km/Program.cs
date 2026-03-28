using System;

namespace milhas_km
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = 0;
            double km = 0;


            Console.WriteLine("Digite a distância em milhas marítimas: ");
            m =double.Parse(Console.ReadLine());

            km = m*1.852;
            Console.WriteLine("Resultado em quilômetros: {0}", km);
            //1,852
            Console.ReadLine(); 
        }
    }
}