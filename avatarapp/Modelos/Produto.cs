namespace Modelos
{
    public class Produto
    {
      string tipodoproduto;
      string unidade;
      string cor;
      string tecido;
      string marca;
      int id;

      Int64 id;

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

    public void SetCor (string cor)
    {
        this.cor= cor;
    }
    public string GetCor()
    {
        return cor;
    }

    public void SetTecido (string tecido)
    {
        this.tecido= tecido;
    }
    public string GetTecido()
    {
        return tecido;
    }

    public void SetMarca (string marca)
    {
        this.marca= marca;
    }
    public string GetMarca()
    {
        return marca;
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