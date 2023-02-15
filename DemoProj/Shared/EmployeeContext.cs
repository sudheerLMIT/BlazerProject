using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoProj.Shared.Models;

namespace DemoProj.Shared
{
    public class EmployeeContext : DbContext
    {

        public virtual DbSet<Employee> Employees { get; set; }




    }
}
