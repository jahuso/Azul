using Blue.DAL;
using Blue.DAL.Interface;
using Blue.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IGenericRepository<Patient> _genericRepository;

        public PatientController(IGenericRepository<Patient> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        // GET: api/Patient
        [HttpGet]
        public async Task<IEnumerable<Patient>> GetPatient()
        {
            //return await _patientRepository.GetAll();
            return await _genericRepository.GetAll();
        }

        // GET: api/Patient/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            var patient = await _genericRepository.GetbyId(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        //// PUT: api/Patient/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatient(string id, Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            if (id != patient.ID)
            {
                return BadRequest();
            }

            try
            {
                await _genericRepository.Update(patient);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
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

        // POST: api/Patient
        [HttpPost]
        public async Task<ActionResult<Patient>> PostPatient(Patient patient)
        {
            //_context.Patient.Add(patient);
            //await _context.SaveChangesAsync();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _genericRepository.Add(patient);
            return CreatedAtAction("GetPatient", new { id = patient.ID }, patient);
        }

        // DELETE: api/Patient/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Patient>> DeletePatient(int id)
        {
            //var patient = await _context.Patient.FindAsync(id);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patient = _genericRepository.GetbyId(id);
            if (patient == null)
            {
                return NotFound();
            }

            _genericRepository.Delete(patient);
            return Ok(patient);
        }

        private bool Exists(int id)
        {
            return _genericRepository.Exists(id);
        }
    }
}
