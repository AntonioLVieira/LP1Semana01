using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0 ; i < args.Length ; i++)
            {
                Console.ReadLine();
                Console.WriteLine("args given :" + args.Length);
                Console.WriteLine(args[i]);
            }
        }
    }
}