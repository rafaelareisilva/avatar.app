namespace Modelos
{
    public class Estampa 
    {
        string nome;
        string telefone;
        int id;
        string produto;
        string prazo;
        string quantidade;
        string entrada;
        string cor; 
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

    public void SetPrazo (string prazo)
    {
        this.prazo= prazo;
    }
    public string GetPrazo()
    {
        return prazo;
    }

    public void SetQuantidade (string quantidade)
    {
        this.quantidade= quantidade;
    }
    public string GetQuantidade()
    {
        return quantidade;
    }

    public void SetEntrada (string entrada)
    {
        this.entrada= entrada;
    }
    public string GetEntrada()
    {
        return entrada;
    }

     public void SetCor (string cor)
    {
        this.cor= cor;
    }
    public string GetCor()
    {
        return cor;
    }
     
    }
}