public class CreateChatRequestDto
{
    public string Name { get; set; }

    public List<int> UsersIds { get; set; }

    public DateTime ValidTo { get; set;}
}