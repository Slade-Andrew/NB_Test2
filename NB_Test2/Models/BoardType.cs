using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NB_Test2.Models
{
    public class BoardType
    {
        [Key]
        public int BoardType_ID { get; set; }
        public string BoardType_Name { get; set; }
        public string BoardType_Desc { get; set; }

        public virtual ICollection<Board> Boards { get; set; }
    }
}