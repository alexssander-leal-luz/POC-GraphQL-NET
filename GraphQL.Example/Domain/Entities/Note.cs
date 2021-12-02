using Telluria.Utils.Crud.Entities;

namespace GraphQL.Example.Domain.Entities
{
  public class Note : BaseEntity
  {
    public Note() { }

    public Note(string message)
    {
      Message = message;
    }

    public string? Message { get; set; }
  }
}
