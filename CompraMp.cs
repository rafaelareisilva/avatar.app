public class CompraMp : pessoa
{
    string nome;
    string telefone;
    string id;
    string materiaPrima;
    string unidade;
    decimal valor;

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

   
    public void SetMateriaPrima (string materiaprima)
    {
        this.materiaPrima= materiaprima;
    }
    public string GetMateriaPrima()
    {
        return materiaprima;
    }


    public void SetUnidade (string unidade)
    {
        this.unidade= unidade;
    }
    public string GetUnidade()
    {
        return unidade;
    }

    
    public void SetValor (decimal valor)
    {
        this.valor= valor;
    }
    public decimal GetValor()
    {
        return valor;
    }

}