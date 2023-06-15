using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example.DI
{
    class CustomerDataAccess : ICustomerDataAccess
    {
        public string GetCustomerName(int id)
        {
            return "Nguyen Van Teo";
        }
    }
}
