namespace avatarapp.Modelos;
public class Cliente : Pessoa
{
    string nome;
    string telefone;
    int id;
    string endereco;
      
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

          public void SetEndereco (string endereco)
    {
        this.endereco= endereco;
    }
    public string GetEndereco()
    {
        return endereco;
    }
}