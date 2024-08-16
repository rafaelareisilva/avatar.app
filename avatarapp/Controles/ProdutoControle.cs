using avatarapp.Modelos;

namespace Controles;

public class ProdutoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ProdutoControle () : base()
  {
    NomeDaTabela = "Produto";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Produto>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Produto>(NomeDaTabela);
    return new List<Produto>(tabela.FindAll().OrderBy(d => d.Id));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Produto cliente)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}