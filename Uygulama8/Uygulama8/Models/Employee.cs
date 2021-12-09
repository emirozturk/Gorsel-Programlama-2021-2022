using System;
using System.Collections.Generic;

namespace Uygulama8.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; } = null!;
    }
}
