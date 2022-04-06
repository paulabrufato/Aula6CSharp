using System;

namespace Aula6CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 0;

            Console.WriteLine("Tabuada do 2");

            Console.WriteLine("Digite um número inteiro: ");
            inteiro = int.Parse(Console.ReadLine());

            for(int x = 1; x <= 10; x++)
            {
                Console.WriteLine($"{x} x {inteiro} = {x * inteiro}");                
            }
        }
    }
}
