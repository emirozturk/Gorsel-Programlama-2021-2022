using System;
using System.Collections.Generic;

namespace Uygulama8.Models
{
    public partial class CustomerService
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}
