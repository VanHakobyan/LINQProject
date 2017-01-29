using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCustomer
{
    struct Customer
    {
        readonly string nameCustomer;
        readonly string model;
        readonly string phoneNumber;

        public Customer(string nameCustomer, string model, string phoneNumber)
        {
            this.nameCustomer = nameCustomer;
            this.model = model;
            this.phoneNumber = phoneNumber;

        }


        public string NameCustomer { get { return nameCustomer; } }
        public string Model { get { return model; } }
        public string PhoneNumber { get { return phoneNumber; } }


        public override string ToString()
        {
            return $"Name Customer: {nameCustomer} Model:{model} phone number: {phoneNumber}";
        }

    }
}
