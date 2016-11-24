using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarNotes.Common.Models
{
    [Table("UserNote")]
    public class UserNote
    {
        [Required]
        public int UserNoteId { get; set; }
        [Required]
        public string Note { get; set; }
        [Required]
        public DateTime Date { get; set; }

        //Navigation Properties
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
