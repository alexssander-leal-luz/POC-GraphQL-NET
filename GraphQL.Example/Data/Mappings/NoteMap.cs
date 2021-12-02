using GraphQL.Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telluria.Utils.Crud.Mapping;

namespace GraphQL.Example.Data.Mappings
{
  public class NoteMap : BaseEntityMap<Note>
  {
    public override void Configure(EntityTypeBuilder<Note> builder)
    {
      base.Configure(builder);

      builder.ToTable("reg_notes");

      builder.Property(x => x.Message).HasColumnName("message").HasColumnType("varchar(100)").IsRequired();
    }
  }
}
