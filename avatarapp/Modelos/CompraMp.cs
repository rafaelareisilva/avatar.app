using LiteDB;

namespace avatarapp.Modelos;

public class CompraMp 
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public string Materiaprima { get; set; }
  public string Unidade { get; set; }
  public decimal Valor { get; set; }
}