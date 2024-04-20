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
    [Route("api/chats")]
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

            return Ok(chat);
        }

        [HttpPost]
        public async Task<ActionResult<Chats>> CreateChat(CreateChatRequestDto request)
        {
            if(request.UsersIds == null || request.UsersIds.Count == 0 
                || request.Name == null || request.Name == "") {
                    return BadRequest("Parameters dont match requirements");
            }

            var chat = await _chatsService.CreateChatAsync(request);

            return CreatedAtAction(nameof(GetChatById), new { id = chat.Id }, chat);;
        }

        // [HttpGet("/userChats/{id}")]
        // public async Task<ActionResult<IEnumerable<Chats>>> GetChatsByUserId(int id)
        // {
        //     var chats = await _chatsService.GetChatByIdAsync(id);

        //     if (chats == null) {
        //         return NoContent();
        //     }

        //     return chats;
        // }
    } 
}
