using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example.DI
{
    class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.ProcessCustomerData(id);
        }

        //static void Main(string[] args)
        //{

        //    CustomerService cs = new CustomerService();
        //    Console.Write(cs.GetCustomerName(1));
        //    Console.Read();
        //}

    }
}
