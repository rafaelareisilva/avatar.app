namespace Modelos
{
    public class FornecedorMp : pessoa
    {
        int idmp;
        int idfornecedor;
        
         Int64 id;

    public void SetIdmp (int idmp)
    {
        this.idmp= idmp;
    }
    public int GetIdmp()
    {
        return idmp;
    }


    public void SetIdfornecedor (int idfornecedor)
    {
        this.idfornecedor= idfornecedor;
    }
    public int GetIdfornecedor()
    {
        return idfornecedor;
    }

    }
}


