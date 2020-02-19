using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mb905315_MIS4200.Models
{
    public class Patient
    {

        public int patientID { get; set; }

        [Display (Name = "First name")]
        public string firstName { get; set; }
        [Display (Name = "Last name")]
        public string lastName { get; set; }

        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        [Display (Name = "Email")]
        public string email { get; set; }
        [Display (Name = "Mobile phone")]
        public string phone { get; set; }
        [Display (Name = "Patient since")]
        public DateTime patientSince { get; set; }
        [Display (Name = "Date of visit")]
        public ICollection<Visit> Vist { get; set; }

        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)

        
    }
}