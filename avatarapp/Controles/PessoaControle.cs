using avatarapp.Modelos;

namespace Controles;

public class PessoaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public PessoaControle () : base()
  {
    NomeDaTabela = "Pessoa";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Pessoa>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pessoa>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pessoa>(NomeDaTabela);
    return new List<Pessoa>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Pessoa>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pessoa cliente)
  {
    var collection = liteDB.GetCollection<Pessoa>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}