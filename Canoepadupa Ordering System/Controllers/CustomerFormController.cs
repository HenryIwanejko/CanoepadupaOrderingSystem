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
        public static List<Customer> listOfCustomers = new List<Customer>();

        public CustomerFormController()
        {
            RetrieveCustomers();
        }

        private void RetrieveCustomers()
        {
            listOfCustomers = DatabaseService.getAllCustomers();
        }

        public void AddCustomersToListView(ref ListView listView)
        {
            foreach (var customer in listOfCustomers)
            {
                listView.Items.Add(new ListViewItem(new string[] { customer.CustomerNumber.ToString(), customer.CustomerName }));
            }
        }

        public Customer GetCustomer(int customerNumber)
        {
            foreach(var customer in listOfCustomers)
            {
                if (customer.CustomerNumber == customerNumber)
                {
                    return customer;
                }
            }
            return null;
        }


    }
}
