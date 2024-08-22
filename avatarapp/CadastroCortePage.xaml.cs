using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroCortePage : ContentPage
    {
        Controles.CortadorControle cortadorControle = new Controles.CortadorControle();
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        public CadastroCortePage()
        {
            InitializeComponent();

            pickerCortador.ItemsSource = cortadorControle.LerTodos();
            pickerProduto.ItemsSource = produtoControle.LerTodos();

            VoltarButton.Clicked += OnVoltarButtonClicked;
            CadastrarButton.Clicked += OnCadastrarButtonClicked;
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página anterior
            Navigation.PopAsync();
        }

        private void OnCadastrarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar os dados
           
           
            string quantidade = QuantidadeEntry.Text;
            string entrada = EntradaEntry.Text;
            string prazo = PrazoEntry.Text;
            string cor = CorEntry.Text;

            // Implementar a lógica de cadastro aqui

            DisplayAlert("Sucesso", "Cadastro realizado com sucesso", "OK");
        }
    }
}
