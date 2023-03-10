using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Ejemplo
{
    public abstract class Perro
    {
        public virtual string Ladrar()
        {
            return "Perro Ladrando";
        }
        public abstract string Dormir();
    }
}
