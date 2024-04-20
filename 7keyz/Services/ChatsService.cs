using _7keyz.Constants;
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

        // public async Task<List<Chats>> GetUserChatsByUserId(int userId)
        // {
        //     return await _context.Chats
        //                          .Where(y => y.Users.Any(u => u.Id == userId))
        //                          .ToListAsync();
        // }

        public async Task<Chats> CreateChatAsync(CreateChatRequestDto request) 
        {
            Chats chat = ChatsMapper.MapChatRequestDtoToChatsEntity(request);
            
            chat = InsertUsersInChat(chat, request.UsersIds);

             _context.Chats.Add(chat);
            await _context.SaveChangesAsync();

            return chat;
        }

        public Chats InsertUsersInChat(Chats chat, List<int> users) 
        {
            if(chat.Users == null) {
                chat.Users = new List<ChatsUsers>();
            }
            
            foreach(int userId in users)
            {
                var chatUser = new ChatsUsers
                {
                    usersId = userId,
                    chatsId = chat.Id
                };

                chat.Users.Add(chatUser);
            }

            return chat;
        }
    }
}