using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanoepadupaOrderingSystem.Segues;
using CanoepadupaOrderingSystem.Services;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Controllers;

namespace CanoepadupaOrderingSystem.Forms
{
    public partial class AddCustomerForm : Form
    {
        private readonly AddCustomerFormController addCustomerFormController = new AddCustomerFormController();
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AppSegues.SegueToCustomerForm(this);
        }
        
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) {
                Customer newCustomer = new Customer(
                        tbxCustomerNameValue.Text,
                        tbxAddressLine1Value.Text,
                        tbxAddressLine2Value.Text,
                        tbxAddressLine3Value.Text,
                        tbxPostcodeValue.Text,
                        tbxPhoneNumberValue.Text,
                        tbxEmailValue.Text,
                        int.Parse(tbxCustomerDiscountValue.Text),
                        tbxSecurityQuestionValue.Text,
                        tbxSecurityAnswerValue.Text
                    );
                addCustomerFormController.AddCustomer(newCustomer);
                AppSegues.SegueToCustomerForm(this);
            }
            else
            {
                MessageBox.Show("Please fill in all fields in the correct format");
            }
        }
        
        private void AddCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private bool ValidateAddress(string text)
        {
            return !(!string.IsNullOrEmpty(text) && text.All(ch => Char.IsLetterOrDigit(ch) || ch == ' '));
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void tbxCustomerNameValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCustomerNameValue.Text) && tbxCustomerNameValue.Text.All(Char.IsLetter))
            {
                errorProvider.SetError(tbxCustomerNameValue, "Please Provide Valid Customer Name");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbxCustomerNameValue, null);
            }
        }

        private void tbxAddressLine1Value_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateAddress(tbxAddressLine1Value.Text))
            {
                errorProvider.SetError(tbxAddressLine1Value, "Please Provide Valid Address");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbxAddressLine1Value, null);
            }
        }

        private void tbxAddressLine2Value_Validating(object sender, CancelEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tbxAddressLine2Value.Text)))
            {
                if (ValidateAddress(tbxAddressLine2Value.Text))
                {
                    errorProvider.SetError(tbxAddressLine2Value, "Please Provide Valid Address");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(tbxAddressLine2Value, null);
                }
            }
            else
            {
                errorProvider.SetError(tbxAddressLine2Value, null);
            }
        }

        private void tbxAddressLine3Value_Validating(object sender, CancelEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tbxAddressLine3Value.Text)))
            {
                if (ValidateAddress(tbxAddressLine3Value.Text))
                {
                    errorProvider.SetError(tbxAddressLine3Value, "Please Provide Valid Address");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(tbxAddressLine3Value, null);
                }
            }
            else
            {
                errorProvider.SetError(tbxAddressLine3Value, null);
            }
        }

        private void tbxPostcodeValue_Validating(object sender, CancelEventArgs e)
        {
            if (!(Regex.IsMatch(tbxPostcodeValue.Text, "^([A-Z]{1,2})([0-9][0-9A-Z]?) ([0-9])([ABDEFGHJLNPQRSTUWXYZ]{2})$")))
            {
                errorProvider.SetError(tbxPostcodeValue, "Please Provide Valid Postcode");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbxPostcodeValue, null);
            }
        }

        private void tbxPhoneNumberValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPhoneNumberValue.Text) || !tbxPhoneNumberValue.Text.All(ch => Char.IsDigit(ch) || ch == ' '))
            {
                errorProvider.SetError(tbxPhoneNumberValue, "Please Provide Valid Phone Number");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbxPhoneNumberValue, null);
            }
        }

        private void tbxEmailValue_Validating(object sender, CancelEventArgs e)
        {
            if (!(IsValidEmail(tbxEmailValue.Text)))
            {
                errorProvider.SetError(tbxEmailValue, "Please Provide Valid Email");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbxEmailValue, null);
            }
        }

        private void tbxCustomerDiscountValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCustomerDiscountValue.Text) || !tbxCustomerDiscountValue.Text.All(ch => Char.IsDigit(ch) && int.Parse(tbxCustomerDiscountValue.Text) < 100))
            {
                errorProvider.SetError(tbxCustomerDiscountValue, "Please Provide Valid Number Between: 0-100");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbxCustomerDiscountValue, null);
            }
        }

        private void tbxSecurityQuestionValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSecurityQuestionValue.Text) || !tbxSecurityQuestionValue.Text.All(ch => Char.IsLetterOrDigit(ch) || ch == ' '))
            {
                errorProvider.SetError(tbxSecurityQuestionValue, "Please Provide Valid Security Question");
                e.Cancel = true;
            } else
            {
                errorProvider.SetError(tbxSecurityQuestionValue, null);
            }
        }

        private void tbxSecurityAnswerValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSecurityAnswerValue.Text) || !tbxSecurityAnswerValue.Text.All(ch => Char.IsLetterOrDigit(ch) || ch == ' '))
            {
                errorProvider.SetError(tbxSecurityAnswerValue, "Please Provide Valid Security Answer");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbxSecurityAnswerValue, null);
            }
        }
    }
}
