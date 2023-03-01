using System;
using System.Collections.Generic;

namespace P620231_API.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int ScheduleId { get; set; }
        public DateTime ScheduleDateStart { get; set; }
        public DateTime ScheduleDateEnd { get; set; }
        public int InitialTime { get; set; }
        public int FinalTime { get; set; }
        public string? Notes { get; set; }
        public bool? PromoDay { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
