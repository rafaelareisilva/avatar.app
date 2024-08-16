using LiteDB;

namespace avatarapp.Modelos;

public class Produto : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Tipodopruduto { get; set; }
  public string Unidade { get; set; }
  public string Cor { get; set; }
  public string Tecido { get; set; }
  public string Marca { get; set; }
}