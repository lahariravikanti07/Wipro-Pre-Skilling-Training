using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationOfMay29.Models;

namespace WebApplicationOfMay29.Data
{
    public class WebApplicationOfMay29Context : DbContext
    {
        public WebApplicationOfMay29Context (DbContextOptions<WebApplicationOfMay29Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationOfMay29.Models.Employee> Employee { get; set; } = default!;
    }
}
