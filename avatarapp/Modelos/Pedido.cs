
using LiteDB;

namespace avatarapp.Modelos;

public class Pedido : Registro
{
  [BsonId]
  public int Id { get; set; }
  public Cliente Cliente { get; set; }
  public Produto Produto { get; set; }
  public Unidade Unidade { get; set; }
  public string Prazo { get; set; }
  public decimal Valor { get; set; }
  public decimal Desconto { get; set; }
  public decimal Total { get; set; }
}