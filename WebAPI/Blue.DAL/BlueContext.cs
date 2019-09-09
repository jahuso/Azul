using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blue.DAL
{
    public class BlueDBContext : DbContext
    {
        public BlueDBContext(DbContextOptions<BlueDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Module> Module { get; set; }
    }
}
