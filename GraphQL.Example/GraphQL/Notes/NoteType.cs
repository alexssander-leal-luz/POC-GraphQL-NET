using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQLNetExample.Notes
{
  public class NoteType : ObjectGraphType<Note>
  {
    public NoteType()
    {
      Name = "Note";
      Description = "Note Type";
      Field(d => d.Id, nullable: false).Description("Note Id");
      Field(d => d.Message, nullable: true).Description("Note Message");
      Field(d => d.Deleted, nullable: true).Description("Note Deleted");
    }
  }
}
