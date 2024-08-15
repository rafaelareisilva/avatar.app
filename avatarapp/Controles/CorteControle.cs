using avatarapp.Modelos;

namespace Controles;

public class CorteControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CorteControle () : base()
  {
    NomeDaTabela = "Corte";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Corte>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Corte>(NomeDaTabela);
    return new List<Corte>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Corte cliente)
  {
    var collection = liteDB.GetCollection<Corte>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}