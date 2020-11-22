using System;

namespace PatronFactory_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico costo = Convertidor.Convertir(Convertidor.estufa);
            Console.WriteLine(costo.precio());
        }
    }
}
