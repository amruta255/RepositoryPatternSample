using System;
using System.Collections.Generic;

namespace POSApplication.Data.Models
{
    public partial class Customer
    {
        public int Customerid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
    }
}
