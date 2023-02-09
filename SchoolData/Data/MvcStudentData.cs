using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolData.Data
{
	public class MvcStudentContext: DbContext
    {
        public MvcStudentContext(DbContextOptions<MvcStudentContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolData.Models.Student> Student { get; set; }
    }
}