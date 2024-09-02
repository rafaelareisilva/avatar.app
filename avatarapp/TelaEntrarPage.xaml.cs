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
            CompraMPButton.Clicked += OnCompraMPButtonClicked;
            VendaProdutoButton.Clicked += VendaProdutoButtonClicked;
            
        }

        private void OnClienteButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Cliente
            Navigation.PushAsync(new BuscaDeClientePage());
        }

        private void OnUnidadeButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Unidade
            Navigation.PushAsync(new BuscarUnidadePage());
        }

        private void OnPedidoButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Pedido
            Navigation.PushAsync(new BuscarPedido());
        }

        private void OnFornecedorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Fornecedor
            Navigation.PushAsync(new BuscarFornecedor());
        }

        private void OnMateriaPrimaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Matéria Prima
            Navigation.PushAsync(new BuscarMateriaPrima());
        }

        private void OnProdutoButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Produto
            Navigation.PushAsync(new BuscarProduto());
        }

        private void OnCosturaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Costura
            Navigation.PushAsync(new BuscarCosturaPage());
        }

        private void OnCortadorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Cortador
            Navigation.PushAsync(new BuscarCortadorPage());
        }

        private void OnCorteButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Corte
            Navigation.PushAsync(new BuscarCortePage());
        }

        private void OnEstoqueButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estoque
            Navigation.PushAsync(new BuscarEstoquePage());
        }

        private void OnEstampariaButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estamparia
            Navigation.PushAsync(new BuscarEstampariaPage());
        }

        private void OnEstampadorButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Estampador
            Navigation.PushAsync(new BuscarEstampadorPage());
        }

        private void OnCostureiraButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Costureira
            Navigation.PushAsync(new BuscarCostureiraPage());
        }

        private void OnCompraMPButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Costureira
            Navigation.PushAsync(new CadastroCompraMateriaPrima());
        }
            
         private void VendaProdutoButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de Costureira
            Navigation.PushAsync(new VendaProdutoPage());
        }
        
    }
}