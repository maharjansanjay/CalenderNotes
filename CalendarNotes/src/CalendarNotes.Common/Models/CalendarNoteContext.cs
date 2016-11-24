using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarNotes.Common.Models
{
    public class CalendarNoteContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public CalendarNoteContext(DbContextOptions<CalendarNoteContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("User").Property(x => x.Id).HasColumnName("UserId");
            builder.Entity<IdentityRole<int>>().ToTable("Role").Property(x => x.Id).HasColumnName("RoleId");
            builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaim").Property(x => x.Id).HasColumnName("UserClaimId");
            builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaim").Property(x => x.Id).HasColumnName("RoleClaimId");
            builder.Entity<IdentityUserRole<int>>().ToTable("UserRole");
            builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogin");
            builder.Entity<IdentityUserToken<int>>().ToTable("UserToken");
        }
    }
}
