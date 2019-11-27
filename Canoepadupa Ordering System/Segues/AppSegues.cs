using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanoepadupaOrderingSystem.Forms;
using System.Windows.Forms;

namespace CanoepadupaOrderingSystem.Segues
{
    public class AppSegues
    {
        public AppSegues()
        {

        }

        public static void SegueToCustomerForm(Form form)
        {
            var customerForm = new CustomerForm();
            customerForm.Closed += (s, args) => form.Close();
            customerForm.Show();
            form.Hide();
        }

        public static void SegueToOrderBasketForm(Form form)
        {
            var orderBasketForm = new OrderBasketForm();
            orderBasketForm.Closed += (s, args) => form.Close();
            orderBasketForm.Show();
            form.Hide();
        } 

        public static void SegueToOrderHistoryCustomer(Form form)
        {
            var orderHistoryForm = new CustomerOrderHistoryForm();
            orderHistoryForm.Closed += (s, args) => form.Close();
            orderHistoryForm.Show();
            form.Hide();
        }

        public static void SegueToAddCustomerForm(Form form)
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.Closed += (s, args) => form.Close();
            addCustomerForm.Show();
            form.Hide();
        }
    }
}
