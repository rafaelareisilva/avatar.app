using avatarapp.Modelos;

namespace Controles;

public class FornecedorMpControle : BaseControle
{
  //----------------------------------------------------------------------------

  public FornecedorMpControle () : base()
  {
    NomeDaTabela = "FornecedorMp";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<FornecedorMp>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<FornecedorMp>? LerTodos()
  {
    var tabela = liteDB.GetCollection<FornecedorMp>(NomeDaTabela);
    return new List<FornecedorMp>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<FornecedorMp>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(FornecedorMp cliente)
  {
    var collection = liteDB.GetCollection<FornecedorMp>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}