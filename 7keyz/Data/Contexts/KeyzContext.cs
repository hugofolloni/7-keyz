using Microsoft.EntityFrameworkCore;

public partial class KeyzContext : DbContext
{
    public DbSet<Users> Users { get; set; }
    public DbSet<Messages> Messages { get; set; }
    public DbSet<Chats> Chats { get; set; }
    public DbSet<ChatsUsers> ChatsUsers { get; set; }

    public KeyzContext()
    {
    }

    public KeyzContext(DbContextOptions<KeyzContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=7keyz;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}