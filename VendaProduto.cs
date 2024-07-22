public class VendaProduto : pessoa
{
    string nome;
    string telefone;
    string id;
    string produto;
    string unidade;
     Int64 id;

    public void SetNome (string nome)
    {
        this.nome= nome;
    }
    public string GetNome()
    {
        return nome;
    }


    public void SetTelefone (string telefone)
    {
        this.telefone= telefone;
    }
    public string GetTelefone()
    {
        return telefone;
    }


      public void SetId (string id)
    {
        this.id= id;
    }
    public string GetId()
    {
        return id;
    }

   
    public void SetProduto (string produto)
    {
        this.produto= produto;
    }
    public string GetProduto()
    {
        return produto;
    }


    public void SetUnidade (string unidade)
    {
        this.unidade= unidade;
    }
    public string GetUnidade()
    {
        return unidade;
    }

}