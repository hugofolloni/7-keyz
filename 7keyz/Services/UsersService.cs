using _7keyz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _7keyz.Services {
    public class UsersService() : IUsersService {
        private readonly KeyzContext _context;

        public UsersService(KeyzContext context) : this()
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Users>>> GetUserById(int id) 
        {
            return await _context.Users.ToListAsync();
        }
    }
}