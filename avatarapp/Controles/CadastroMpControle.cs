
using avatarapp.Modelos;
using avatarapp.Modelos;

namespace Controles;

public class CadastroMpControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CadastroMpControle() : base()
  {
    NomeDaTabela = "CadastroMp";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<CadastroMP>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<CadastroMP>? LerTodos()
  {
    var tabela = liteDB.GetCollection<CadastroMP>(NomeDaTabela);
    return new List<CadastroMP>(tabela.FindAll().OrderBy(d => d.Id));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<CadastroMP>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(CadastroMP cliente)
  {
    var collection = liteDB.GetCollection<CadastroMP>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}