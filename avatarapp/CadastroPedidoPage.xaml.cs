using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroPedidoPage : ContentPage
    {
        public CadastroPedidoPage()
        {
            InitializeComponent();
        }

        private void OnSelectClienteClicked(object sender, EventArgs e)
        {
            // Lógica para selecionar cliente
        }

        private void OnSelectUnidadeMedidaClicked(object sender, EventArgs e)
        {
            // Lógica para selecionar unidade de medida
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Cadastrar"
            string nomeCliente = NomeClienteEntry.Text;
            string telefone = TelefoneEntry.Text;
            string produto = ProdutoEntry.Text;
            string unidadeMedida = UnidadeMedidaEntry.Text;
            string valor = ValorEntry.Text;
            string desconto = DescontoEntry.Text;
            string prazo = PrazoEntry.Text;
            string total = TotalEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados do pedido
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }
    }
}