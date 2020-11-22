using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory_CSharp
{
    class Estufa : Electrodomestico
    {
        public override int precio()
        {
            return 50000;
        }
    }
}
