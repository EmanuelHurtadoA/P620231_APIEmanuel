using System;
using System.Collections.Generic;

namespace P620231_API.Models
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppoDate { get; set; }
        public int AppoStart { get; set; }
        public int AppoEnd { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Notes { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public int ScheduleId { get; set; }
        public int AppoStatusId { get; set; }

        public virtual AppointmentStatus AppoStatus { get; set; } = null!;
        public virtual Schedule Schedule { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
