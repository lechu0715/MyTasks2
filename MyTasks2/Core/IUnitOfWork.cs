using MyTasks2.Core.Repositories;
using MyTasks2.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasks2.Core
{
    public interface IUnitOfWork
    {
        ITaskRepository Task { get; }
        void Complete();
    }
}
