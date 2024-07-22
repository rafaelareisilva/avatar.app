public class Fornecedor : pessoa
{
    string nome;
    string telefone;
    string id;
    string tipodoproduto;
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

   
    public void SetTipodoproduto (string tipodoproduto)
    {
        this.tipodoproduto= tipodoproduto;
    }
    public string GetTipodoproduto()
    {
        return tipodoproduto;
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