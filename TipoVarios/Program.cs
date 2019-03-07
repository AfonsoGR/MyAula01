using System;

namespace TiposVarios
{
    class Program
    {/// <summary>
     /// exercicio de aula
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int number = 100;
            float dottedNumber = 3.14f;
            double pi = 3.1415;
            long longNumber = 99999L;
            sbyte smallNumber = 2;
            char letter = '\u0469';
            string god = "Cthulhu";
            bool alive = true;
            bool dead = false;

            Console.WriteLine("inteiro: " + number);
            Console.WriteLine("float: " + dottedNumber);
            Console.WriteLine("double: " + pi);
            Console.WriteLine("long: " + longNumber);
            Console.WriteLine("sbyte: " + smallNumber);
            Console.WriteLine("char: " + letter);
            Console.WriteLine("string: " + god);
            Console.WriteLine("bool T: " + alive);
            Console.WriteLine("bool F: " + dead);

            Console.Read();
        }
    }
}