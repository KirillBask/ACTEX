using System.Linq;
using ACTEX.Data;
using ACTEX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ACTEX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("GetUsers")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers([FromBody] User filterModel)
        {
            IQueryable<User> users = _context.Users;

            if (!string.IsNullOrEmpty(filterModel.Id))
            {
                users = users.Where(u => u.Id != null && u.Id == filterModel.Id);
            }
            if (!string.IsNullOrEmpty(filterModel.Login))
            {
                users = users.Where(u => u.Login != null && u.Login.Contains(filterModel.Login));
            }
            if (!string.IsNullOrEmpty(filterModel.Password))
            {
                users = users.Where(u => u.Password != null && u.Password.Contains(filterModel.Password));
            }
            if (!string.IsNullOrEmpty(filterModel.Name))
            {
                users = users.Where(u => u.Name != null && u.Name.Contains(filterModel.Name));
            }
            if (!string.IsNullOrEmpty(filterModel.TypeId))
            {
                users = users.Where(u => u.TypeId != null && u.TypeId.Contains(filterModel.TypeId));
            }
            if (filterModel.LastVisitDate != null)
            {
                users = users.Where(u => u.LastVisitDate == filterModel.LastVisitDate);
            }

            return await users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser != null)
            {
                return Conflict();
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
