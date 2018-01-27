﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NB_Test2.Models
{
    public class Role
    {
        [Key]
        public int Role_ID { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<MemberOfRole> MemberOfRoles { get; set; }
    }
}