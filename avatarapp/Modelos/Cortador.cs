using LiteDB;

namespace avatarapp.Modelos;

public class Cortador : Pessoa
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public string Endereco { get; set; }
}