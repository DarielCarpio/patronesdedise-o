using System;

namespace Patronprototype_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase_Platano viveres = new Clase_Platano() { Maduro = "Este platano esta maduro", Verde = "Este platano esta verde" };

            Clase_Platano viveresclonado = viveres.Clone() as Clase_Platano;

            viveresclonado.Verde = "Este platano esta hervido";

            Console.WriteLine(viveres.Verde);

            Console.ReadKey();

        }
    }
}
