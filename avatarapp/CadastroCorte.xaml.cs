using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroCortePage : ContentPage
    {
        public CadastroCortePage()
        {
            InitializeComponent();

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
            string nome = NomePicker.SelectedItem?.ToString();
            string produto = ProdutoPicker.SelectedItem?.ToString();
            string quantidade = QuantidadeEntry.Text;
            string entrada = EntradaEntry.Text;
            string prazo = PrazoEntry.Text;
            string cor = CorEntry.Text;

            // Implementar a lógica de cadastro aqui

            DisplayAlert("Sucesso", "Cadastro realizado com sucesso", "OK");
        }
    }
}
