﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_OOP
{
    public class Customer
    {
        //constructors
        public Customer()
        {

        }
        public Customer (int customerId)
        {
            CustomerId = customerId;
            AddresList = new List<Address>();

        }

    //attributes
        public int CustomerId { private set; get; }
        public int CustomerType { set; get; }
        public string EmailAddress { set; get; }
        public string FirstName { set; get; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
        public string LastName { set; get; }
        public static int InstanceCount { set; get; }
        public string email { set; get; }

        public override string ToString() =>FullName;



        public Customer Retrieve(int CustomerId)
        {
            return new Customer();

        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }





        public bool Validate(){
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

    }

}
