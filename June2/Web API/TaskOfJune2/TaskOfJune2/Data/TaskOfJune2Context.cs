using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskOfJune2.Models;

namespace TaskOfJune2.Data
{
    public class TaskOfJune2Context : DbContext
    {
        public TaskOfJune2Context (DbContextOptions<TaskOfJune2Context> options)
            : base(options)
        {
        }

        public DbSet<TaskOfJune2.Models.Employee> Employee { get; set; } = default!;
    }
}
