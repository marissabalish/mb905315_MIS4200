﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mb905315_MIS4200.Models
{
    public class Doctor
    {
        [Key]
        public int doctorID { get; set; }
        [Display(Name = "First name")]
        public string firstName { get; set; }
        [Display(Name = "Last name")]

        public string fullName
        {
            get 
            {
                return lastName + ", " + firstName;
            }
        }
        public string lastName { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Mobile phone")]
        public string phone { get; set; }
        [Display(Name = "Visit date")]
        public ICollection<Visit> VisitDetails { get; set; }

        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)

    }
}