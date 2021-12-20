using MyTasks2.Core;
using MyTasks2.Core.Repositories;
using MyTasks2.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasks2.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _context;

        public UnitOfWork(IApplicationDbContext context)
        {
            _context = context;
            Task = new TaskRepository(context);
        }

        public ITaskRepository Task { get; set; }

        public void Complete()
        {
            _context.SaveChanges();
        }

    }
}
