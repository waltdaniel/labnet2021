using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    abstract class TransportePublico
    {
        public int pasajeros { get; set; } 

        abstract public void Avanzar();
        abstract public void Detenerse();
    }
}
