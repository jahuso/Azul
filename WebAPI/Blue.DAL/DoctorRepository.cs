using System;
using System.Collections.Generic;
using System.Text;

namespace Blue.DAL
{
    public class DoctorRepository: GenericRepository<Doctor>
    {
        private readonly BlueDBContext _dbContext;
        public DoctorRepository(BlueDBContext context): base(context)
        {
            this._dbContext = context;
        }
    }
}
