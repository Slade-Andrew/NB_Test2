using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NB_Test2.Models
{
    public class MemberOf
    {
        [Key]
        public int PerOrgParent_ID { get; set; }
        public int PerOrgChild_ID { get; set; }

        public virtual PerOrg PerOrgParent { get; set; }
        public virtual PerOrg PerOrgChild { get; set; }
        public virtual ICollection<MemberOfRole> MemberOfRoles { get; set; }
    }
}