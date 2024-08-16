using avatarapp.Modelos;

namespace Controles;

public class RegistroControle : BaseControle
{
  //----------------------------------------------------------------------------

  public RegistroControle () : base()
  {
    NomeDaTabela = "Registro";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Registro>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Registro>(NomeDaTabela);
    return new List<Registro>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Registro cliente)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}