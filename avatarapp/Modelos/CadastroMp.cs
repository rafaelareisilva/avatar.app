namespace Modelos
{
public class CadastroMp
{
    int id;
    string tipodoproduto;
    string unidade;
     Int64 id;
     
      public void SetId (int id)
    {
        this.id= id;
    }
    public int GetId()
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
}