using Blue.DAL.Models;
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

        public virtual DbSet<Doctor> Appointment { get; set; }
        public virtual DbSet<Module> ClinicHistory { get; set; }
        public virtual DbSet<Module> ConsultingRoom { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }

        public virtual DbSet<Module> Evolution { get; set; }
        public virtual DbSet<Doctor> HistoryDetail { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<Doctor> Order { get; set; }
        public virtual DbSet<Module> Patient { get; set; }
        public virtual DbSet<Doctor> PhysicalExam { get; set; }
        public virtual DbSet<Module> Role { get; set; }
        public virtual DbSet<Module> User { get; set; }
    }
}
