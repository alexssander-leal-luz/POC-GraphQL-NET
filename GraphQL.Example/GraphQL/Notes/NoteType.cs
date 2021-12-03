using GraphQL.Example.Domain.Entities;
using GraphQL.Types;

namespace GraphQL.Example.GraphQl.Notes
{
  public class NoteType : ObjectGraphType<Note>
  {
    public NoteType()
    {
      Name = "Note";
      Description = "Note Type";
      Field(d => d.Id).Description("Note Id");
      Field(d => d.Message).Description("Note Message");
      Field(d => d.Deleted).Description("Note Deleted");
    }
  }
}
