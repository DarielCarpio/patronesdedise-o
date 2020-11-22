using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory_CSharp
{
    public class Convertidor
    {
        public const int nevera = 1;
        public const int estufa = 5;

        public static Electrodomestico Convertir(int tipo)
        {
            switch (tipo)
            {
                case nevera:
                    return new Nevera();
                case estufa:
                    return new Estufa();
                default: return null;
            }
        }
    }
}
