using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
