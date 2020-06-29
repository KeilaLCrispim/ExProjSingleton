using System;

namespace ProjetoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            singletonClass singleton = singletonClass.GetInstance;

            Console.WriteLine(singleton.numero);

            singleton.numero = 20;

            singletonClass singleton2 = singletonClass.GetInstance;

            Console.WriteLine(singleton2.numero);

            singleton2.numero += 38;

            Console.WriteLine(singleton.numero);

            Console.Read();
        }
    }
}
