using Blue.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Models
{
    public class ModuleContext: DbContext
    {
        public ModuleContext(DbContextOptions<ModuleContext> options) : base(options)
        {

        }

        public DbSet<Module> Module { get; set; }
    }
}
