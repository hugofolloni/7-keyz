public class Chats {
    public int Id { get; set; }

    public string Name { get; set; }

    public int StatusCode { get; set;}

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public virtual ICollection<ChatsUsers>? Users { get; set; }

    public virtual ICollection<Messages>? Messages { get; set; }
}