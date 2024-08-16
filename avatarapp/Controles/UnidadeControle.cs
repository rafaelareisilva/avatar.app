using avatarapp.Modelos;

namespace Controles;

public class UnidadeControle : BaseControle
{
  //----------------------------------------------------------------------------

  public UnidadeControle () : base()
  {
    NomeDaTabela = "Unidade";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Unidade>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return new List<Unidade>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Unidade cliente)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}