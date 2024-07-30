namespace avatarapp.Modelos;
public class VendaProduto 
{
    string nome;
    string telefone;
    int id;
    string produto;
    string unidade;
    

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


      public void SetId (int id)
    {
        this.id= id;
    }
    public int GetId()
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
}