using Blue.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultingRoomsController : ControllerBase
    {
        private readonly BlueDBContext _context;

        public ConsultingRoomsController(BlueDBContext context)
        {
            _context = context;
        }

        // GET: api/ConsultingRooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsultingRoom>>> GetConsultingRoom()
        {
            return await _context.ConsultingRoom.ToListAsync();
        }

        // GET: api/ConsultingRooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsultingRoom>> GetConsultingRoom(string id)
        {
            var consultingRoom = await _context.ConsultingRoom.FindAsync(id);

            if (consultingRoom == null)
            {
                return NotFound();
            }

            return consultingRoom;
        }

        // PUT: api/ConsultingRooms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultingRoom(string id, ConsultingRoom consultingRoom)
        {
            if (id != consultingRoom.ID)
            {
                return BadRequest();
            }

            _context.Entry(consultingRoom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultingRoomExists(id))
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

        // POST: api/ConsultingRooms
        [HttpPost]
        public async Task<ActionResult<ConsultingRoom>> PostConsultingRoom(ConsultingRoom consultingRoom)
        {
            _context.ConsultingRoom.Add(consultingRoom);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsultingRoom", new { id = consultingRoom.ID }, consultingRoom);
        }

        // DELETE: api/ConsultingRooms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsultingRoom>> DeleteConsultingRoom(string id)
        {
            var consultingRoom = await _context.ConsultingRoom.FindAsync(id);
            if (consultingRoom == null)
            {
                return NotFound();
            }

            _context.ConsultingRoom.Remove(consultingRoom);
            await _context.SaveChangesAsync();

            return consultingRoom;
        }

        private bool ConsultingRoomExists(string id)
        {
            return _context.ConsultingRoom.Any(e => e.ID == id);
        }
    }
}
