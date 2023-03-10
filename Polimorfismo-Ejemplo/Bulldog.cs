using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Ejemplo
{
    public class Bulldog:Perro 
    {
        public override string Ladrar()
        {
            return "Bulldog Ladrando";
        }
        public override string Dormir()
        {
            return "Bulldog Durmiendo";
        }

    }
}
