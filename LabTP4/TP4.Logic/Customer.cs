using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Data;

namespace TP4.Logic
{
    class Customer
    {
        private readonly EntityContext context;
        public Customer()
        {
            context = new EntityContext();
        }

    }
}
