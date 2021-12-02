using GraphQL.Types;

namespace GraphQL.Example.GraphQl.Notes
{
  public class NotesSchema : Schema
  {
    public NotesSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
      Query = serviceProvider.GetRequiredService<NotesQuery>();
      Mutation = serviceProvider.GetRequiredService<NotesMutation>();
    }
  }
}
