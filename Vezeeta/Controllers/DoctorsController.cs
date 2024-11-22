using Microsoft.AspNetCore.Mvc;
using Vezeeta.Data;

namespace Vezeeta.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult BookAppointment()
        {    
            var Ds=_context.Doctors.ToList(); 
            return View(Ds);
        }
        public IActionResult CompleteAppointment(int id)
        {
            var D = _context.Doctors.Find(id);
            return View(D);
        }
        public IActionResult CreateAppointment(string Patientname,DateOnly AppointmentDate, TimeOnly AppointmentTime)
        {
            _context.Appointments.Add(new()
            {
                PatiantName = Patientname,
                AppointmentDate = AppointmentDate,
                AppointmentTime = AppointmentTime
            });
            _context.SaveChanges();
            return RedirectToAction("ShowList");
        }
        public IActionResult ShowList()
        {
            var list = _context.Appointments.ToList();
            return View(list);
        }

    }
}
