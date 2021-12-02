using GraphQL.Example.Data.Mappings;
using GraphQL.Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Example.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Note>? Notes { get; set; }
    public DbSet<Book>? Books { get; set; }
    public DbSet<Publisher>? Publishers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfiguration(new NoteMap());
      modelBuilder.ApplyConfiguration(new BookMap());
      modelBuilder.ApplyConfiguration(new PublisherMap());
    }
  }
}
