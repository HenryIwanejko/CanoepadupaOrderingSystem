using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Services;

namespace CanoepadupaOrderingSystem.Controllers
{
    class AddCustomerFormController
    {
        public AddCustomerFormController()
        {

        }

        public void AddCustomer(Customer customer)
        {
            DatabaseService.AddCustomer(customer);
        }
    }
}
