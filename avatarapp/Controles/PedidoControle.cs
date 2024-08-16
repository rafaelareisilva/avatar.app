using avatarapp.Modelos;

namespace Controles;

public class PedidoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public PedidoControle () : base()
  {
    NomeDaTabela = "Pedido";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pedido>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return new List<Pedido>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pedido cliente)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}