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
    
    public partial class PatientAllergie
    {
        public int AllergyId { get; set; }
        public string Discription { get; set; }
        public int PatientHealthRecordId { get; set; }
        public string Name { get; set; }
    
        public virtual PatientHealthRecord PatientHealthRecord { get; set; }
    }
}
