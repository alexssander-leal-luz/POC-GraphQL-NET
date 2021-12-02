using GraphQL.Example.Data.Mappings;
using GraphQL.Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estudos.BaltaIO.Tarefas.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfiguration(new NoteMap());
    }
  }
}
