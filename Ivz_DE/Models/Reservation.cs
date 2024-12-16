using System;
using System.Collections.Generic;

namespace Ivz_DE.Models
{
    public partial class Reservation
    {
        public Reservation()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public int? GuestId { get; set; }
        public int? RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; } = null!;

        public virtual Guest? Guest { get; set; }
        public virtual Room? Room { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
