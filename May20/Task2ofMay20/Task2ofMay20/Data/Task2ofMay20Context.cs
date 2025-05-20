using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task2ofMay20.Models;

namespace Task2ofMay20.Data
{
    public class Task2ofMay20Context : DbContext
    {
        public Task2ofMay20Context (DbContextOptions<Task2ofMay20Context> options)
            : base(options)
        {
        }

        public DbSet<Task2ofMay20.Models.Department> Department { get; set; } = default!;
    }
}
