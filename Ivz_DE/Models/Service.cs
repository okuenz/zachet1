using System;
using System.Collections.Generic;

namespace Ivz_DE.Models
{
    public partial class Service
    {
        public Service()
        {
            GuestServices = new HashSet<GuestService>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<GuestService> GuestServices { get; set; }
    }
}
