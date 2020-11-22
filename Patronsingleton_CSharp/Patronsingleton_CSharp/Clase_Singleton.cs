using System;
using System.Collections.Generic;
using System.Text;

namespace Patronsingleton_CSharp
{
    public class Clase_Singleton
    {

        private static Clase_Singleton instance = null;
        public string Nombre = "";

        protected Clase_Singleton() {
            Nombre = "Escriba su nombre por favor";
        }

        

        public static Clase_Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Clase_Singleton();

                return instance;
            }
        }
    }
}
