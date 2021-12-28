using MyTasks2.Core.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasks2.Core.ViewModels
{
    public class CategoryViewModel
    {
        public string Heading { get; set; }
        public Category Category { get; set; }
    }
}
