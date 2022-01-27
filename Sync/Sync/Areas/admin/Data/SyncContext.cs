using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sync.Models;

namespace Sync.Data
{
    public class SyncContext : IdentityDbContext
    {
        public SyncContext (DbContextOptions<SyncContext> options)
            : base(options)
        {
        }

        public DbSet<Sync.Models.Setting> Setting { get; set; }

        public DbSet<Sync.Models.Social> Social { get; set; }
        public DbSet<Sync.Models.CustomUser> CustomUser { get; set; }
    }
}
