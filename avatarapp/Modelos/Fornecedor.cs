using LiteDB;

namespace avatarapp.Modelos;

public class Fornecedor : Pessoa
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public string Tipodoproduto { get; set; }
  public Unidade Unidade { get; set; }
}