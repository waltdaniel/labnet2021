using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Data;
using TP4.Entities;

namespace TP4.Logic
{
    public class CustomersLogic
    {
        private readonly EntityContext context;
        public CustomersLogic()
        {
            context = new EntityContext();
        }
        public List<Customers> GetTodos()
        {
            return context.Customers.ToList();
        }
    }
}
