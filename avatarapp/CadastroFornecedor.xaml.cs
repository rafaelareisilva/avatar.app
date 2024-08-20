using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroFornecedor : ContentPage
    {
        Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
       

        public CadastroFornecedor()
        {
            InitializeComponent();

            pickerUnidade.ItemsSource = unidadeControle.LerTodos();


            FinalizarButton.Clicked += OnFinalizarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnFinalizarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para finalizar o cadastro
            await DisplayAlert("Cadastro", "Cadastro finalizado com sucesso!", "OK");
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
