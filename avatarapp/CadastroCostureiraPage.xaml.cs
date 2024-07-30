using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroCostureiraPage : ContentPage
    {
        public CadastroCostureiraPage()
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
            string telefone = TelefoneEntry.Text;
            string endereco = EnderecoEntry.Text;

            // Implementar a lógica de cadastro aqui

            DisplayAlert("Sucesso", "Cadastro realizado com sucesso", "OK");
        }
    }
}
