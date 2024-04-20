using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _7keyz.Services;
using _7keyz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _7keyz.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        private readonly KeyzContext _context;

        private readonly IChatsService _chatsService;

        public ChatsController(KeyzContext context, IChatsService chatsService)
        {
            _context = context;
            _chatsService = chatsService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Chats>> GetChatById(int id)
        {
            var chat = await _chatsService.GetChatByIdAsync(id);

            if (chat == null) {
                return NoContent();
            }

            return chat;
        }    
    } 
}
