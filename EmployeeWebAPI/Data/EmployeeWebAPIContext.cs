using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeWebAPI.Model;

namespace EmployeeWebAPI.Data
{
    public class EmployeeWebAPIContext : DbContext
    {
        public EmployeeWebAPIContext (DbContextOptions<EmployeeWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeWebAPI.Model.Employee> Employee { get; set; }
    }
}
