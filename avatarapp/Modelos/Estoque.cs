using LiteDB;

namespace avatarapp.Modelos;

public class Estoque : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Materiaprima { get; set; }
  public string Quantidade { get; set; }
  public string Entrada { get; set; }
  public string Fornecedor { get; set; }
}