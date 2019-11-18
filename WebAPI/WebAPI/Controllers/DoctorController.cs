using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using Blue.DAL.Interface;
using Blue.DAL;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IGenericRepository<Doctor> _genericRepository;
        public DoctorController(IGenericRepository<Doctor> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        // GET: api/Doctor
        [HttpGet]
        public Task<IEnumerable<Doctor>> GetDoctor()
        {
            return _genericRepository.GetAll();
        }

        // GET: api/Doctor/5
        [HttpGet("{id}")]
        public IActionResult GetDoctor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var doctor = _genericRepository.GetbyId(id);

            if (doctor == null)
            {
                return NotFound();
            }

            return Ok(doctor);
        }

        // PUT: api/Doctor/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctor([FromRoute] int id, [FromBody] Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != doctor.Code)
            {
                return BadRequest();
            }

            try
            {
                await _genericRepository.Update(doctor);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoctorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        //// POST: api/Doctor
        [HttpPost]
        public IActionResult PostDoctor([FromBody] Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _genericRepository.Add(doctor);
            return CreatedAtAction("GetDoctor", new { id = doctor.Code }, doctor);
        }

        //// DELETE: api/Doctor/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var doctor = _genericRepository.GetbyId(id);
            if (doctor == null)
            {
                return NotFound();
            }

            _genericRepository.Delete(doctor);

            return Ok(doctor);
        }

        private bool DoctorExists(int id)
        {
            return _genericRepository.Exists(id);
        }
    }
}