using LiteDB;

namespace avatarapp.Modelos;

public class Unidade
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  
}
