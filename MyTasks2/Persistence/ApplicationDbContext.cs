using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyTasks2.Core;
using MyTasks2.Core.Models.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTasks2.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        
    }
}
