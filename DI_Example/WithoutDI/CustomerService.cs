using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example.WithoutDI
{
    class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic();
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }

        static void Main(string[] args)
        {

            CustomerService cs = new CustomerService();
            Console.Write(cs.GetCustomerName(1));
            Console.Read();
        }
    }
}
