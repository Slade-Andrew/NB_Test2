using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NB_Test2.Models
{
    public class MemberOfRole
    {
        [Key]
        public int PerOrgParent_ID { get; set; }
        public int PerOrgChild_ID { get; set; }
        public int Role_ID { get; set; }

        public virtual MemberOf MemberOf { get; set; }
        public virtual Role Role { get; set; }
    }
}