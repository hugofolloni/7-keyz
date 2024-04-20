using _7keyz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _7keyz.Services {
    public class ChatsService() : IChatsService {
        private readonly KeyzContext _context;

        public ChatsService(KeyzContext context) : this()
        {
            _context = context;
        }

        public async Task<Chats?> GetChatByIdAsync(int id) 
        {
            return await _context.Chats.FindAsync(id);
        }
    }
}