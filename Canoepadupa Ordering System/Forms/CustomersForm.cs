using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Constants;
using CanoepadupaOrderingSystem.Controllers;
using CanoepadupaOrderingSystem.Forms;

namespace CanoepadupaOrderingSystem
{
    public partial class CustomerForm : Form
    {
        private CustomerFormController customerformController = new CustomerFormController();

        public static Customer Customer { get; private set; }

        public CustomerForm()
        {
            InitializeComponent();
            SetUpForm();
            customerformController.AddCustomersToListView(ref lsvCustomerList);
        }

        private void SetUpForm()
        {
            SetUpFormText();
            ResizeListViewColumns();
            ToggleButtons(false);
        }

        private void SetUpFormText()
        {
            this.Text = CustomersFormConstants.FormText;
            lblFormTitle.Text = CustomersFormConstants.FormTitle;
            lblListViewTitle.Text = CustomersFormConstants.ListViewTitle;
            lblCutomerNumber.Text = CustomersFormConstants.CustomerNumber;
            lblCustomerName.Text = CustomersFormConstants.CustomerName;
            lblAddress.Text = CustomersFormConstants.Address;
            lblPostcode.Text = CustomersFormConstants.Postcode;
            lblPhoneNumber.Text = CustomersFormConstants.Phonenumber;
            lblEmailAddress.Text = CustomersFormConstants.EmailAddress;
            lblCustomerDiscount.Text = CustomersFormConstants.CustomerDiscount;
            lblSecurityQuestion.Text = CustomersFormConstants.SecurityQuestion;
            lblSecurityQuestionAnswer.Text = CustomersFormConstants.SecurityQuestionAnswer;
        }

        private void ResizeListViewColumns()
        {
            lsvCustomerList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvCustomerList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ToggleButtons(bool enabled)
        {
            btnOrderHistory.Enabled = enabled;
            btnTakeOrder.Enabled = enabled;
        }

        private void TakeOrderButton_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                var orderBasketForm = new OrderBasketForm();
                orderBasketForm.Closed += (s, args) => this.Close();
                orderBasketForm.Show();
                Hide();
            }
        }

        private void lsvCustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lsvCustomerList.SelectedItems.Count > 0)) { return; }
            ToggleButtons(true);
            Customer = customerformController.GetCustomer(int.Parse(lsvCustomerList.SelectedItems[0].Text));
            updateCustomerInfomationFields();
        }

        private void updateCustomerInfomationFields()
        {
            lblCustomerNumberValue.Text = Customer.CustomerNumber.ToString();
            lblCustomerNameValue.Text = Customer.CustomerName;
            lblAddressLine1Value.Text = Customer.CustomerAddressLine1;
            lblAddressLine2Value.Text = Customer.CustomerAddressLine2;
            lblAddressLine3Value.Text = Customer.CustomerAddressLine3;
            lblPostCodeValue.Text = Customer.Postcode;
            lblPhoneNumerValue.Text = Customer.Phone;
            lblEmailAddressValue.Text = Customer.Email;
            lblCustomerDiscountValue.Text = Customer.Discount.ToString() + "%";
            lblSecurityQuestionValue.Text = Customer.SecurityQuestion;
            lblSecurityQuesitonAnswerValue.Text = Customer.SecurityQuestionAnswer;
        }
    }
}
