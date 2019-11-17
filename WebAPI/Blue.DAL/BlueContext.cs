using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blue.DAL
{
    public class BlueDBContext : DbContext
    {
        public BlueDBContext(DbContextOptions<BlueDBContext> options) : base(options)
        {

        }
        public  DbSet<Appointment> Appointment { get; set; }
        public  DbSet<ClinicHistory> ClinicHistory { get; set; }
        public  DbSet<ConsultingRoom> ConsultingRoom { get; set; }        
        public  DbSet<Doctor> Doctor { get; set; }
        public  DbSet<Evolution> Evolution { get; set; }
        public  DbSet<EvolutionDetail> EvolutionDetail { get; set; }
        public  DbSet<HistoryDetail> HistoryDetail { get; set; }
        public  DbSet<Module> Module { get; set; }
        public  DbSet<Order> Order { get; set; }
        public  DbSet<Patient> Patient { get; set; }
        public  DbSet<PhysicalExam> PhysicalExam { get; set; }
        public  DbSet<Role> Role { get; set; }

        public  DbSet<User> User { get; set; }
    }
}
