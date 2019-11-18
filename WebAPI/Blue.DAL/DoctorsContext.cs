using Blue.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace Blue.DAL
{
    public class DoctorsContext:DbContext
    {
        public DoctorsContext(DbContextOptions<DoctorsContext>options) : base(options)
        {

        }

        public DbSet<Doctor> Doctor { get; set; }
    }
}
