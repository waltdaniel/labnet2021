using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    class Taxi : TransportePublico
    {
        public Taxi(int pasajeros)
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
