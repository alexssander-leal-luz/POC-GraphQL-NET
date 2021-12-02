using GraphQL.Example.Data;
using GraphQL.Types;

namespace GraphQL.Example.GraphQl.Notes
{
  public class NotesQuery : ObjectGraphType
  {
    public NotesQuery()
    {
      Field<ListGraphType<NoteType>>("notes", resolve: context =>
      {
        var dataContext = context?.RequestServices?.GetRequiredService<DataContext>();

        return dataContext?.Notes.ToList();
      });
    }
  }
}
