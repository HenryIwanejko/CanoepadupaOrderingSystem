using System;
using System.Windows.Forms;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Constants;
using CanoepadupaOrderingSystem.Controllers;
using CanoepadupaOrderingSystem.Forms;
using CanoepadupaOrderingSystem.Segues;
using System.Collections.Generic;

namespace CanoepadupaOrderingSystem
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerFormController customerformController = new CustomerFormController();

        public static Customer Customer { get; private set; }

        public CustomerForm()
        {
            InitializeComponent();
            SetUpForm();
            List<Customer> listOfCustomers = customerformController.ListOfAllCustomers;
            PopulateCustomerListView(listOfCustomers);
        }

        private void SetUpForm()
        {
            SetUpFormText();
            ResizeListViewColumns();
            ToggleButtons(false);
        }

        private void PopulateCustomerListView(List<Customer> listOfCustomers)
        {
            lsvCustomerList.Items.Clear();
            foreach (var customer in listOfCustomers)
            {
                lsvCustomerList.Items.Add(new ListViewItem(new string[] { customer.CustomerNumber.ToString(), customer.CustomerName }));
            }
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
                AppSegues.SegueToOrderBasketForm(this);
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

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                AppSegues.SegueToOrderHistoryCustomer(this);
            }
        }

        private void tbxSearchBox_TextChanged(object sender, EventArgs e)
        {
            List<Customer> searchedForCustomers = customerformController.SearchForCustomer(tbxSearchBox.Text);
            PopulateCustomerListView(searchedForCustomers);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AppSegues.SegueToAddCustomerForm(this);
        }
    }
}
