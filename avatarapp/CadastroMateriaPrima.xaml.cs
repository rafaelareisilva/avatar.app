using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();

        public CadastroMateriaPrima()
        {
            InitializeComponent();
            pickerUnidade.ItemsSource = unidadeControle.LerTodos();

          
            CadastrarButton.Clicked += OnCadastrarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnCadastrarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar a matéria-prima
            await DisplayAlert("Cadastro", "Matéria-prima cadastrada com sucesso!", "OK");
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
