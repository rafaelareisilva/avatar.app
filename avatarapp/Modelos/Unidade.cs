namespace avatarapp.Modelos;
public class Unidade
{
    string nome;
    int id;
    
     public void SetNome (string nome)
    {
        this.nome= nome;
    }
    public string GetNome()
    {
        return nome;
    }

    
      public void SetId (int id)
    {
        this.id= id;
    }
    public int GetId()
    {
        return id;
    }

}
}