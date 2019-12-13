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
        public readonly List<Customer> ListOfAllCustomers = new List<Customer>();

        public CustomerFormController(List<Customer> listOfCustomers = null)
        {
            try
            {
                ListOfAllCustomers = listOfCustomers ?? DatabaseService.GetAllCustomers();
            }
            catch (Exception ex)
            {
                // Pass exception to UI
                throw ex;
            }
        }

        public Customer GetCustomer(int customerNumber)
        {
            foreach(var customer in ListOfAllCustomers)
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

            foreach (Customer customer in ListOfAllCustomers)
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
