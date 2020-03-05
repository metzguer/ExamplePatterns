using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var msgSingleton = PatternSingletton.instance.mensaje; 

            Console.WriteLine(msgSingleton);
        }
    }
}
