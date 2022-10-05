#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CursesAPI.Models;

namespace CursesAPI.Data
{
    public class CursesAPIContext : DbContext
    {
        public CursesAPIContext (DbContextOptions<CursesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CursesAPI.Models.Student> Student { get; set; }

        public DbSet<CursesAPI.Models.Enrollment> Enrollment { get; set; }
    }
}
