using System;

namespace Argumentos
{
    class Program
    { /// <summary>
      /// Aqui começa o código.
      /// </summary>
      /// <param name="args"> Lê os argumentos </param>
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
