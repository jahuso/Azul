using Blue.DAL;
using Blue.DAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        private readonly IGenericRepository<Module> _genericRepository;

        public ModuleController(IGenericRepository<Module> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        // GET: api/Module
        [HttpGet]
        public Task<IEnumerable<Module>> GetModule()
        {
            return _genericRepository.GetAll();
        }

        // GET: api/Module/5
        [HttpGet("{id}")]
        public IActionResult GetModule([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _module = _genericRepository.GetbyId(id);
            if (_module == null)
            {
                return NotFound();
            }

            return Ok(_module);
        }

        // PUT: api/Module/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModule([FromRoute] int id, [FromBody] Module _module)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != _module.Code)
            {
                return BadRequest();
            }

            try
            {
                await _genericRepository.Update(_module);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleExists(id))
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

        // POST: api/Module
        [HttpPost]
        public IActionResult PostModule([FromBody] Module _module)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _genericRepository.Add(_module);
            return CreatedAtAction("GetModule", new { id = _module.Code }, _module);
        }

        // DELETE: api/Module/5
        [HttpDelete("{id}")]
        public IActionResult DeleteModule([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _module = _genericRepository.GetbyId(id);
            if (_module == null)
            {
                return NotFound();
            }

            _genericRepository.Delete(_module);

            return Ok(_module);
        }

        private bool ModuleExists(int id)
        {
            return _genericRepository.Exists(id);
        }
    }
}