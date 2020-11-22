using System;
using System.Collections.Generic;
using System.Text;

namespace Patronprototype_CSharp
{
    public class Clase_Platano : ICloneable
    {
        public string Maduro { get; set; }
        public string Verde { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
