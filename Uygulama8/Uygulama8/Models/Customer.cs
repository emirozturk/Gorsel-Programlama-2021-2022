using System;
using System.Collections.Generic;

namespace Uygulama8.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerServices = new HashSet<CustomerService>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CustomerService> CustomerServices { get; set; }
        public override string? ToString()
        {
            return Name;
        }
    }
}
