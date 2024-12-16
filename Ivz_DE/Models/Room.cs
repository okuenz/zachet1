using System;
using System.Collections.Generic;

namespace Ivz_DE.Models
{
    public partial class Room
    {
        public Room()
        {
            CleaningSchedules = new HashSet<CleaningSchedule>();
            Reservations = new HashSet<Reservation>();
            RoomAccesses = new HashSet<RoomAccess>();
        }

        public int Id { get; set; }
        public string Floor { get; set; } = null!;
        public int Number { get; set; }
        public string Category { get; set; } = null!;
        public string? Status { get; set; }

        public virtual ICollection<CleaningSchedule> CleaningSchedules { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<RoomAccess> RoomAccesses { get; set; }
    }
}
