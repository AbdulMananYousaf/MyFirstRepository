//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public string AppointmentStatus { get; set; }
        public string Discription { get; set; }
        public int DoctorEmployeeId { get; set; }
        public string HeldDate { get; set; }
        public int PatientId { get; set; }
        public int ReceptionistEmployeetId { get; set; }
        public string SetedDate { get; set; }
        public string VisitReson { get; set; }
        public string PatientLastVisitDate { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
