using System;
using System.Collections.Generic;

namespace Ivz_DE.Models
{
    public partial class Guest
    {
        public Guest()
        {
            Reservations = new HashSet<Reservation>();
            RoomAccesses = new HashSet<RoomAccess>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<RoomAccess> RoomAccesses { get; set; }
    }
}
