using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            this._context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await this._context.Users.ToListAsync();

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
           return  await this._context.Users.FindAsync(id);
          
        }
    }

  
}