using MyTasks2.Core.Models;
using MyTasks2.Core.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTasks2.Core.ViewModels
{
    public class TasksViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public FilterTasks FilterTasks { get; set; }
    }
}
