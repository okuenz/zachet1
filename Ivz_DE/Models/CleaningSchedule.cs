using System;
using System.Collections.Generic;

namespace Ivz_DE.Models
{
    public partial class CleaningSchedule
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public DateTime CleaningDate { get; set; }
        public int? CleanerId { get; set; }
        public string Status { get; set; } = null!;

        public virtual Room? Room { get; set; }
    }
}
