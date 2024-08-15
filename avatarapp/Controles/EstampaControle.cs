using avatarapp.Modelos;

namespace Controles;

public class EstampaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EstampaControle  () : base()
  {
    NomeDaTabela = "Estampa";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Estampa>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Estampa>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Estampa>(NomeDaTabela);
    return new List<Estampa>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Estampa>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Estampa cliente)
  {
    var collection = liteDB.GetCollection<Estampa>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}