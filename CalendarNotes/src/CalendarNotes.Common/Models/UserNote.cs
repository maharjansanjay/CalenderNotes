using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public TimeSpan Time { get; set; }

        //Navigation Properties
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
