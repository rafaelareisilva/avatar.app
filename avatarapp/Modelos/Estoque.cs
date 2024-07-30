namespace avatarapp.Modelos;
    public class Estoque
    {
    string materiaPrima;
    string quantidade;
    string entrada;
    string fornecedor;
    int id;

   

     public void SetMateriaPrima (string materiaprima)
    {
        this.materiaPrima= materiaprima;
    }
    public string GetMateriaPrima()
    {
        return materiaPrima;
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

    public void SetFornecedor (int fornecedor)
    {
        this.fornecedor= fornecedor;
    }
    public string GetFornecedor()
    {
        return fornecedor;
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
