using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NB_Test2.Models
{
    public class NoticeStatus
    {
        [Key]
        public int Status_ID { get; set; }
        public int Notice_ID { get; set; }
        public int Board_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Board Board { get; set; }
        public virtual Notice Notice { get; set; }
        public virtual Status Status { get; set; }
    }
}