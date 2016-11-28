using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
