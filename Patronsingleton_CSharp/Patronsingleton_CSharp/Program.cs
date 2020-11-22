using System;

namespace Patronsingleton_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Clase_Singleton.Instance.Nombre);

            string nombre;

            nombre = Console.ReadLine();

            Console.WriteLine("Saludos " + nombre + " espero que se encuentre bien");

            Console.ReadKey();
        }
    }
}
