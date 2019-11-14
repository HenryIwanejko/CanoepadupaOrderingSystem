using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Models
{
    public class Customer
    {
        public int CustomerNumber { get; private set; }
        public string CustomerName { get; private set; }
        public string CustomerAddressLine1 { get; private set; }
        public string CustomerAddressLine2 { get; private set; }
        public string CustomerAddressLine3 { get; private set; }
        public string Postcode { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public int Discount { get; private set; }
        public string SecurityQuestion { get; private set; }
        public string SecurityQuestionAnswer { get; private set; }

        public Customer(int customerNumber,
                        string customerName,
                        string customerAddressLine1,
                        string customerAddressLine2,
                        string customerAddressLine3,
                        string postcode,
                        string phone,
                        string email,
                        int discount,
                        string sercurityQuestion,
                        string securityQuestionAnswer
                        )
        {
            CustomerNumber = customerNumber;
            CustomerName = customerName;
            CustomerAddressLine1 = customerAddressLine1;
            CustomerAddressLine2 = customerAddressLine2;
            CustomerAddressLine3 = customerAddressLine3;
            Postcode = postcode;
            Phone = phone;
            Email = email;
            Discount = discount;
            SecurityQuestion = sercurityQuestion;
            SecurityQuestionAnswer = securityQuestionAnswer;
        }
    }
}
