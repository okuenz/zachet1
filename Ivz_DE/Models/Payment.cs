using System;
using System.Collections.Generic;

namespace Ivz_DE.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int? ReservationId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDaate { get; set; }
        public string? PaymentMethod { get; set; }

        public virtual Reservation? Reservation { get; set; }
    }
}
