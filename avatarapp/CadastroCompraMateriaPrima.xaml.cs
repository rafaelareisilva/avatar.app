using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroCompraMateriaPrima : ContentPage
    {
       Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
       Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
       Controles.CompraMpControle comprampControle = new Controles.CompraMpControle();

        public CadastroCompraMateriaPrima()
        {
            InitializeComponent();

            pickerUnidade.ItemsSource = unidadeControle.LerTodos();
            pickerFornecedor.ItemsSource = fornecedorControle.LerTodos();
            pickerCompraMp.ItemsSource = comprampControle.LerTodos();

            FinalizarButton.Clicked += OnFinalizarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnFinalizarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para finalizar a compra de matéria-prima
            await DisplayAlert("Compra", "Compra de matéria-prima finalizada com sucesso!", "OK");
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
