using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
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
            Navigation.PushAsync(new ClientePage());
        }

        private void OnUnidadeButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Unidade
            Navigation.PushAsync(new UnidadePage());
        }

        private void OnPedidoButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Pedido
            Navigation.PushAsync(new PedidoPage());
        }

        private void OnFornecedorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Fornecedor
            Navigation.PushAsync(new FornecedorPage());
        }

        private void OnMateriaPrimaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Matéria Prima
            Navigation.PushAsync(new MateriaPrimaPage());
        }

        private void OnProdutoButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Produto
            Navigation.PushAsync(new ProdutoPage());
        }

        private void OnCosturaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Costura
            Navigation.PushAsync(new CosturaPage());
        }

        private void OnCortadorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Cortador
            Navigation.PushAsync(new CortadorPage());
        }

        private void OnCorteButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Corte
            Navigation.PushAsync(new CortePage());
        }

        private void OnEstoqueButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estoque
            Navigation.PushAsync(new EstoquePage());
        }

        private void OnEstampariaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estamparia
            Navigation.PushAsync(new EstampariaPage());
        }

        private void OnEstampadorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estampador
            Navigation.PushAsync(new EstampadorPage());
        }

        private void OnCostureiraButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Costureira
            Navigation.PushAsync(new CostureiraPage());
        }
    }
}