using System;
using System.Collections.Generic;
using System.Text;

namespace ATMmachine.Entities
{
    public class Customer
    {
        //Information on Customers
        //Data properties for Customer class
        public string Username { get; set; }
        public string Pin { get; set; }
        public string Name { get; set; }
        public string AccountType { get; set; }
        public string Status { get; set; }
        public int Balance { get; set; }
        public int AccountNo { get; set; }
        
    }
}