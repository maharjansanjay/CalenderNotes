﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace CalendarNotes.Common.Models
{
    public class User: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Properties
        public ICollection<UserNote> UserNotes { get; set; }
    }
}
