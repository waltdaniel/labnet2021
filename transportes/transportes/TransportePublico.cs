using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    abstract class TransportePublico
    {
        public int Pasajeros { get; set; }
        public int Id { get; set; }

        abstract public string Avanzar();
        abstract public string Detenerse();
    }
}
