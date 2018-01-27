using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NB_Test2.Models
{
    public class ViewableBoard
    {
        [Key]
        public int Board_ID { get; set; }
        public int PerOrgParent_ID { get; set; }
        public int PerOrgChild_ID { get; set; }
        public int Role_ID { get; set; }

        public virtual Board Board { get; set; }
        public virtual MemberOfRole MemberOfRole { get; set; }
    }
}