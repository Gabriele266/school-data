using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolData.Models;

namespace SchoolData.Data
{
    public class SchoolDataContext : DbContext
    {
        public SchoolDataContext (DbContextOptions<SchoolDataContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolData.Models.Class> Class { get; set; } 
        public DbSet<SchoolData.Models.Student> Student { get; set; } 

    }
}
