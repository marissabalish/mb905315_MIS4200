using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mb905315_MIS4200.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace mb905315_MIS4200.Models.DAL
{
    public class MIS4200Context : DbContext
    {

        public MIS4200Context() : base("name=DefaultConnection")
        {
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<customer> customers { get; set; }
   
    }
}