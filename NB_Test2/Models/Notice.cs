using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NB_Test2.Models
{
    public class Notice
    {
        [Key]
        public int Notice_ID { get; set; }
        public string NoticeName { get; set; }
        public string NoticeDesc { get; set; }
        public int PerOrg_ID { get; set; }

        public virtual PerOrg PerOrg { get; set; }
        public virtual ICollection<NoticeStatus> NoticeStatuses { get; set; }
    }
}