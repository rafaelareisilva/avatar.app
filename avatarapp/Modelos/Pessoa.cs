using LiteDB;

namespace avatarapp.Modelos;

public class Pessoa : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }

}