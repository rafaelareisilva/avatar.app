using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class TelaEntrarPage : ContentPage
    {
        public TelaEntrarPage()
        {
            InitializeComponent();
            
            ClienteButton.Clicked += OnClienteButtonClicked;
            UnidadeButton.Clicked += OnUnidadeButtonClicked;
            PedidoButton.Clicked += OnPedidoButtonClicked;
            FornecedorButton.Clicked += OnFornecedorButtonClicked;
            MateriaPrimaButton.Clicked += OnMateriaPrimaButtonClicked;
            ProdutoButton.Clicked += OnProdutoButtonClicked;
            CosturaButton.Clicked += OnCosturaButtonClicked;
            CortadorButton.Clicked += OnCortadorButtonClicked;
            CorteButton.Clicked += OnCorteButtonClicked;
            EstoqueButton.Clicked += OnEstoqueButtonClicked;
            EstampariaButton.Clicked += OnEstampariaButtonClicked;
            EstampadorButton.Clicked += OnEstampadorButtonClicked;
            CostureiraButton.Clicked += OnCostureiraButtonClicked;
        }

        private void OnClienteButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Cliente
            Navigation.PushAsync(new CadastroClientePage());
        }

        private void OnUnidadeButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Unidade
            Navigation.PushAsync(new CadastroUnidadePage());
        }

        private void OnPedidoButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Pedido
            Navigation.PushAsync(new CadastroPedidoPage());
        }

        private void OnFornecedorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Fornecedor
            Navigation.PushAsync(new CadastroFornecedor());
        }

        private void OnMateriaPrimaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Matéria Prima
            Navigation.PushAsync(new CadastroMateriaPrima());
        }

        private void OnProdutoButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Produto
            Navigation.PushAsync(new CadastroProdutoPage());
        }

        private void OnCosturaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Costura
            Navigation.PushAsync(new CadastroCosturaPage());
        }

        private void OnCortadorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Cortador
            Navigation.PushAsync(new CadastroCortador());
        }

        private void OnCorteButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Corte
            Navigation.PushAsync(new CadastroCortePage());
        }

        private void OnEstoqueButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estoque
            Navigation.PushAsync(new EstoquePage());
        }

        private void OnEstampariaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estamparia
            Navigation.PushAsync(new CadastroEstampariaPage());
        }

        private void OnEstampadorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estampador
            Navigation.PushAsync(new CadastroEstampadorPage());
        }

        private void OnCostureiraButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Costureira
            Navigation.PushAsync(new CadastroCostureiraPage());
        }
    }
}