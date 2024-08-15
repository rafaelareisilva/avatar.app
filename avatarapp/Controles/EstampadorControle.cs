using avatarapp.Modelos;

namespace Controles;

public class EstampadorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EstampadorControle  () : base()
  {
    NomeDaTabela = "Estampador";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Estampador>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Estampador>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Estampador>(NomeDaTabela);
    return new List<Estampador>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Estampador>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Estampador cliente)
  {
    var collection = liteDB.GetCollection<Estampador>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}