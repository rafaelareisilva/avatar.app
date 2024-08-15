using avatarapp.Modelos;

namespace Controles;

public class CostureiraControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CostureiraControle () : base()
  {
    NomeDaTabela = "Costureira";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Costureira>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Costureira>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Costureira>(NomeDaTabela);
    return new List<Costureira>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Costureira>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Costureira cliente)
  {
    var collection = liteDB.GetCollection<Costureira>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}