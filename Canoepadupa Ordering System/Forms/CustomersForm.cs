using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanoepadupaOrderingSystem
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            this.SetUpForm();
        }

        private void SetUpForm()
        {
            this.Text = Constants.CustomersFormConstants.FormText;
            this.FormTitle.Text = Constants.CustomersFormConstants.FormTitle;
            this.ListViewTitle.Text = Constants.CustomersFormConstants.ListViewTitle;
            this.TextField1.Text = Constants.CustomersFormConstants.TextField1;
            this.TextField2.Text = Constants.CustomersFormConstants.TextField2;
            this.TextField3.Text = Constants.CustomersFormConstants.TextField3;
            this.TextField4.Text = Constants.CustomersFormConstants.TextField4;
            this.TextField5.Text = Constants.CustomersFormConstants.TextField5;
            this.TextField6.Text = Constants.CustomersFormConstants.TextField6;
            this.TextField7.Text = Constants.CustomersFormConstants.TextField7;
            this.TextField8.Text = Constants.CustomersFormConstants.TextField8;
            this.TextField9.Text = Constants.CustomersFormConstants.TextField9;
        }

    }
}
