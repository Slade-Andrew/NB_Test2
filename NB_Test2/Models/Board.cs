using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NB_Test2.Models
{
    public class Board
    {
        [Key]
        public int Board_ID { get; set; }
        public int BoardType_ID { get; set; }
        public int PerOrg_ID { get; set; }
        public string BoardName { get; set; }
        public string BoardDesc { get; set; }

        public virtual BoardType BoardType_lu { get; set; }
        public virtual PerOrg PerOrg { get; set; }
        public virtual ICollection<NoticeStatus> NoticeStatuses { get; set; }
        public virtual ICollection<ViewableBoard> ViewableBoards { get; set; }
    }
}