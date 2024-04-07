using Microsoft.AspNetCore.Mvc;

namespace _7keyz.Services.Interfaces {
    public interface IUsersService {
        public Task<ActionResult<IEnumerable<Users>>> GetUserById(int id);
    }
}