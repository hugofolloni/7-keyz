using _7keyz.Constants;

public class ChatsMapper {
    public static Chats MapChatRequestDtoToChatsEntity(CreateChatRequestDto chatRequestDto)
    {
        Chats chat = new Chats();

        chat.Name = chatRequestDto.Name;
        chat.StatusCode = ChatStatusCodes.ACTIVE;
        chat.ValidFrom = DateTime.Now;
        chat.ValidFrom = chatRequestDto.ValidTo;
        chat.Users = new List<ChatsUsers>();
        chat.Messages = new List<Messages>();

        return chat;
    }
}