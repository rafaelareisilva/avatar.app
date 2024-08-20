using avatarapp;
using LiteDB;

namespace avatarapp.Modelos;

public class CadastroMP : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Tipodopruduto { get; set; }
  public Unidade Unidade { get; set; }
  
}