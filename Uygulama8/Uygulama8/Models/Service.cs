using System;
using System.Collections.Generic;

namespace Uygulama8.Models
{
    public partial class Service
    {
        public Service()
        {
            CustomerServices = new HashSet<CustomerService>();
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CustomerService> CustomerServices { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
