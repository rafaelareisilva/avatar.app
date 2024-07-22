public class Cliente : pessoa
{
    string nome;
    string telefone;
    string id;
    string endereco
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

          public void SetEndereco (string endereco)
    {
        this.endereco= endereco;
    }
    public string GetEndereco()
    {
        return endereco;
    }
}