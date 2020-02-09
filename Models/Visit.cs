using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mb905315_MIS4200.Models
{
    public class Visit
    {
        public int visitID { get; set; }
        public string description { get; set; }
        public DateTime visitDate { get; set; }

 
        // the next two properties link the visitDetail to the Patient
        public int patientID { get; set; }


        public virtual Patient Patient { get; set; }
       
        // the next two properties link the vistiDetail to the Doctor
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}