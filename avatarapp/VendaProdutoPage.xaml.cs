using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class VendaProdutoPage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        public VendaProdutoPage()
        {
            InitializeComponent();
            pickerCliente.ItemsSource = clienteControle.LerTodos();
            pickerUnidade.ItemsSource = unidadeControle.LerTodos();
            pickerProduto.ItemsSource = produtoControle.LerTodos();
        }
    }
}
