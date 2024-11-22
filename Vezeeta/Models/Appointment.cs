namespace Vezeeta.Models
{
    public class Appointment
    {
        public int id { get; set; }
        public string PatiantName { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
    }
}
