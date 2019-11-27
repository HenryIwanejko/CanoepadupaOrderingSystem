using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Services;
using System.Windows.Forms;

namespace CanoepadupaOrderingSystem.Controllers
{
    public class CustomerFormController
    {
        public readonly List<Customer> listOfAllCustomers = new List<Customer>();

        public CustomerFormController()
        {
            listOfAllCustomers = DatabaseService.GetAllCustomers();
        }

        public Customer GetCustomer(int customerNumber)
        {
            foreach(var customer in listOfAllCustomers)
            {
                if (customer.CustomerNumber == customerNumber)
                {
                    return customer;
                }
            }
            return null;
        }

        public List<Customer> SearchForCustomer(string searchText)
        {
            List<Customer> searchedListOfCustomers = new List<Customer>();

            foreach (Customer customer in listOfAllCustomers)
            {
                if (customer.CustomerName.ToLower().Contains(searchText.ToLower()))
                {
                    searchedListOfCustomers.Add(customer);
                }
            }

            return searchedListOfCustomers;
        }

    }
}
