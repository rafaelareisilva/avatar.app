using LiteDB;

namespace avatarapp.Modelos;

public class Estampa : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public string Produto { get; set; }
  public string Prazo { get; set; }
  public string Quantidade { get; set; }
  public string Entrada { get; set; }
  public string Cor { get; set; }
}