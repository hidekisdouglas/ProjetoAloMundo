using System;

namespace ConsoleApp1
{
    class Program
    {
        static void EscreveNaTela(String txt)
        {
            Console.WriteLine(txt);
        }
        static void EscreveNaTela2(String txt)
        {
            Console.WriteLine(txt);

        }
        static void Main(string[] args)
        {
            EscreveNaTela("Alo Mundo!");
            Console.ReadKey();
        }
    }
}