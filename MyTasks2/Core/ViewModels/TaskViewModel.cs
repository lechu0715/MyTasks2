using MyTasks2.Core.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTasks2.Core.ViewModels
{
    public class TaskViewModel
    {
        public string Heading { get; set; }
        public Task Task { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
