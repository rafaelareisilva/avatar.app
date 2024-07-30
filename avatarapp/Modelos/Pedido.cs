
namespace avatarapp.Modelos;
    public class Pedido 
    {
        string nome;
        string telefone;
        int id;
        string produto;
        string unidade;
        decimal valor;
        decimal desconto;
        decimal total;
        string prazo;
        
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

        public void SetDesconto (decimal desconto)
        {
            this.desconto= desconto;
        }
        public decimal GetDesconto()
        {
            return desconto;
        }

        public void SetTotal (decimal total)
        {
            this.total= total;
        }
        public decimal GetTotal()
        {
            return total;
        }

         public void SetPrazo (string prazo)
        {
            this.prazo= prazo;
        }
        public string GetPrazo()
        {
            return prazo;
        }


    }
}