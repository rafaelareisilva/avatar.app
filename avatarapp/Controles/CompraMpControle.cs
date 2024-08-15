using avatarapp.Modelos;

namespace Controles;

public class CompraMpControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CompraMpControle () : base()
  {
    NomeDaTabela = "CompraMp";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<CompraMp>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<CompraMp>? LerTodos()
  {
    var tabela = liteDB.GetCollection<CompraMp>(NomeDaTabela);
    return new List<CompraMp>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<CompraMp>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(CompraMp cliente)
  {
    var collection = liteDB.GetCollection<CompraMp>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}