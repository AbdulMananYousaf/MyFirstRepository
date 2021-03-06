using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DistributedPatientHealthCareSystem.DPHCSModels;
using Microsoft.AspNetCore.Authorization;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace DistributedPatientHealthCareSystem.Controllers
{
    [Authorize(Roles ="Doctor")]
    public class DoctorController : Controller
    {
        private readonly DPHCSContext _context;
     
        public DoctorController(DPHCSContext context)
        {
            
            _context = context;
            
        }
        public IActionResult Index()
        {
            var AppointmentList = _context.Appointment
                .Include(p => p.Patient.PatientNavigation).Where(d => d.DoctorEmployeeId.ToString() == User.Identity.Name).ToList();
            //IList<Appointment> AppointmentList=_context.Appointment.Where(d => d.DoctorEmployeeId.ToString() == User.Identity.Name).ToList();
            AppointmentList.Count();
           
            return View(AppointmentList);
        }
    }
}