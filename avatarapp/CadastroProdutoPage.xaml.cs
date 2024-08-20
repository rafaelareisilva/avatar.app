using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroProdutoPage : ContentPage
    {
        Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        public CadastroProdutoPage()
        {
            InitializeComponent();
            pickerUnidade.ItemsSource = unidadeControle.LerTodos();
        }
    }
}
