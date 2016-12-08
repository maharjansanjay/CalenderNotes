using System;
using System.ComponentModel.DataAnnotations;

namespace CalendarNotes.Web.Models
{
    public class UserNoteViewModel
    {
        public int UserNoteId { get; set; }
        [Required]
        public string Note { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
    }
}
