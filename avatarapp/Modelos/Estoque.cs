namespace Modelos
{
    public class Estoque
    {
    string materiaPrima;
    string quantidade;
    string entrada;
    string fornecedor;
    int id;

    Int64 id;

     public void SetMateriaPrima (string materiaprima)
    {
        this.materiaPrima= materiaprima;
    }
    public string GetMateriaPrima()
    {
        return materiaprima;
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
    public int GetFornecedor()
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
