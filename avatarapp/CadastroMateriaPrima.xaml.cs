using System.Collections.Generic;
using avatarapp.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        CadastroMpControle cadastrompControle = new CadastroMpControle();

        public CadastroMateriaPrima()
        {
            InitializeComponent();
            pickerUnidade.ItemsSource = unidadeControle.LerTodos();

          
            CadastrarButton.Clicked += OnCadastrarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnCadastrarButtonClicked(object sender, EventArgs e)
        {
            var mp = new CadastroMP();
            mp.Unidade = pickerUnidade.SelectedItem as Unidade;

            unidadeControle.CriarOuAtualizar(mp);

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
