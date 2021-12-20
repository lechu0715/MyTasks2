using Microsoft.EntityFrameworkCore;
using MyTasks2.Core.Models.Domains;

namespace MyTasks2.Core
{
    public interface IApplicationDbContext
    {
        DbSet<Task> Tasks { get; set; }
        DbSet<Category> Categories { get; set; }
        int SaveChanges();
    }
}
