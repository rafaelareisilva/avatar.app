using avatarapp.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroPedidoPage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        public CadastroPedidoPage()
        {
            InitializeComponent();
            pickerCliente.ItemsSource = clienteControle.LerTodos();
            pickerProduto.ItemsSource = produtoControle.LerTodos();
            pickerUnidade.ItemsSource = unidadeControle.LerTodos();
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
            var p = new Pedido();
            p.Cliente = pickerCliente.SelectedItem as Cliente;
            p.Produto = pickerProduto.SelectedItem as Produto;
            p.Unidade = pickerUnidade.SelectedItem as Unidade;
            
            p.Total = decimal.Parse(TotalEntry.Text);
            



            // Lógica para o botão "Cadastrar"
       
           
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