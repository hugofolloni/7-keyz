using Microsoft.AspNetCore.Mvc;

namespace _7keyz.Services.Interfaces {
    public interface IChatsService {
        public Task<Chats?> GetChatByIdAsync(int id);

        public Task<Chats> CreateChatAsync(CreateChatRequestDto request);

         public Chats InsertUsersInChat(Chats chats, List<int> users);
    }
}