using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NB_Test2.Models
{
    public class PerOrgLocation
    {
        [Key]
        public int PerOrg_ID { get; set; }
        public int Location_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrefContactNumber { get; set; }
        public string AltContactNumber { get; set; }

        public virtual PerOrg PerOrg { get; set; }
        public virtual Location Location { get; set; }
    }
}