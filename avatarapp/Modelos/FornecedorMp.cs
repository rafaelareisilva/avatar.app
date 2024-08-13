using LiteDB;

namespace avatarapp.Modelos;

public class FornecedorMp : Pessoa
{
  [BsonId]
  public int Idmp { get; set; }
  public int Idfornecedor { get; set; }
  
}



