using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class DoctorsContext:DbContext
    {
        public DoctorsContext(DbContextOptions<DoctorsContext>options) : base(options)
        {

        }

        public DbSet<Doctor> Doctor { get; set; }
    }
}
