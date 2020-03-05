using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            while (op!=1) {

                var msgSingleton = PatternSingletton.Instance.ConexionDB;

                Console.WriteLine("Conexion a DB: "+msgSingleton);

                Console.WriteLine("Desea voler a obtener la conexión ?");
                Console.WriteLine("Presione 1 para finalizar la ejecución");

                op = Convert.ToInt32( Console.ReadLine() );
            } 
           
        }
    }
}
