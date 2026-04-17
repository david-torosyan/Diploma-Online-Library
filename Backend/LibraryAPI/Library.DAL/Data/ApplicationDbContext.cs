using Library.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Conversation> Conversations { get; set; }
    public DbSet<ConversationParticipant> ConversationParticipants { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Author>().ToTable("authors");
        builder.Entity<Category>().ToTable("categories");
        builder.Entity<Book>().ToTable("books");
        builder.Entity<Favorite>().ToTable("favorites");
        builder.Entity<Review>().ToTable("reviews");
        builder.Entity<Conversation>().ToTable("conversations");
        builder.Entity<ConversationParticipant>().ToTable("conversation_participants");
        builder.Entity<ChatMessage>().ToTable("chat_messages");

        // ----------------------------
        // Primary Keys
        // ----------------------------

        builder.Entity<Author>()
            .HasKey(a => a.Id);

        builder.Entity<Category>()
            .HasKey(c => c.Id);

        builder.Entity<Book>()
            .HasKey(b => b.Id);

        builder.Entity<Review>()
            .HasKey(r => r.Id);

        builder.Entity<Favorite>()
            .HasKey(f => new { f.ApplicationUserId, f.BookId });

        builder.Entity<Conversation>()
            .HasKey(c => c.Id);

        builder.Entity<ConversationParticipant>()
            .HasKey(cp => new { cp.ConversationId, cp.ApplicationUserId });

        builder.Entity<ChatMessage>()
            .HasKey(m => m.Id);

        // ----------------------------
        // Relationships
        // ----------------------------

        // Book → Author
        builder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId)
            .OnDelete(DeleteBehavior.Cascade);

        // Book → Category
        builder.Entity<Book>()
            .HasOne(b => b.Category)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        // Review → User
        builder.Entity<Review>()
            .HasOne(r => r.User)
            .WithMany(u => u.Reviews)
            .HasForeignKey(r => r.ApplicationUserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Review → Book
        builder.Entity<Review>()
            .HasOne(r => r.Book)
            .WithMany(b => b.Reviews)
            .HasForeignKey(r => r.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        // Favorite → User
        builder.Entity<Favorite>()
            .HasOne(f => f.User)
            .WithMany(u => u.Favorites)
            .HasForeignKey(f => f.ApplicationUserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Favorite → Book
        builder.Entity<Favorite>()
            .HasOne(f => f.Book)
            .WithMany(b => b.Favorites)
            .HasForeignKey(f => f.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        // Conversation -> Creator
        builder.Entity<Conversation>()
            .HasOne(c => c.CreatedByUser)
            .WithMany(u => u.ConversationsCreated)
            .HasForeignKey(c => c.CreatedByUserId)
            .OnDelete(DeleteBehavior.Restrict);

        // ConversationParticipant -> Conversation
        builder.Entity<ConversationParticipant>()
            .HasOne(cp => cp.Conversation)
            .WithMany(c => c.Participants)
            .HasForeignKey(cp => cp.ConversationId)
            .OnDelete(DeleteBehavior.Cascade);

        // ConversationParticipant -> User
        builder.Entity<ConversationParticipant>()
            .HasOne(cp => cp.User)
            .WithMany(u => u.ConversationParticipants)
            .HasForeignKey(cp => cp.ApplicationUserId)
            .OnDelete(DeleteBehavior.Cascade);

        // ChatMessage -> Conversation
        builder.Entity<ChatMessage>()
            .HasOne(m => m.Conversation)
            .WithMany(c => c.Messages)
            .HasForeignKey(m => m.ConversationId)
            .OnDelete(DeleteBehavior.Cascade);

        // ChatMessage -> Sender
        builder.Entity<ChatMessage>()
            .HasOne(m => m.SenderUser)
            .WithMany(u => u.ChatMessagesSent)
            .HasForeignKey(m => m.SenderUserId)
            .OnDelete(DeleteBehavior.Restrict);

        // Helpful indexes for chat querying at scale.
        builder.Entity<Conversation>()
            .HasIndex(c => c.LastMessageAtUtc);

        builder.Entity<ConversationParticipant>()
            .HasIndex(cp => cp.ApplicationUserId);

        builder.Entity<ChatMessage>()
            .HasIndex(m => new { m.ConversationId, m.SentAtUtc });

        builder.Entity<ChatMessage>()
            .Property(m => m.SentAtUtc)
            .HasColumnType("timestamptz");

        builder.Entity<Conversation>()
            .Property(c => c.CreatedAtUtc)
            .HasColumnType("timestamptz");

        builder.Entity<Conversation>()
            .Property(c => c.LastMessageAtUtc)
            .HasColumnType("timestamptz");

        builder.Entity<ConversationParticipant>()
            .Property(cp => cp.JoinedAtUtc)
            .HasColumnType("timestamptz");

        builder.Entity<ConversationParticipant>()
            .Property(cp => cp.LastReadAtUtc)
            .HasColumnType("timestamptz");

        builder.Entity<Book>()
            .Property(b => b.PublishedDate)
            .HasColumnType("timestamptz");

        SeedDataFactory.SeedData(builder);
    }
}
