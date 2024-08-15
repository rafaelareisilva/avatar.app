using avatarapp.Modelos;

namespace Controles;

public class CosturaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CosturaControle () : base()
  {
    NomeDaTabela = "Costura";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Costura>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Costura>(NomeDaTabela);
    return new List<Costura>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Costura cliente)
  {
    var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}