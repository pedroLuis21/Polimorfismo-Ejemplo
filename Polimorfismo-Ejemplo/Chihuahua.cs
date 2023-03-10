using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Ejemplo
{
    public class Chihuahua:Perro
    {
        public override string Ladrar()
        {
            return "Chihuahua Ladrando";
        }
        public override string Dormir()
        {
            return "Chihuahua Durmiendo";
        }

    }
}
