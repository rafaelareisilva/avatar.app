using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroClientePage : ContentPage
    {
        public CadastroClientePage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string telefone = TelefoneEntry.Text;
            string endereco = EnderecoEntry.Text;

            // Lógica para cadastrar o cliente
            DisplayAlert("Sucesso", "Cliente cadastrado com sucesso!", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnExcluirSimClicked(object sender, EventArgs e)
        {
            // Lógica para excluir o cliente
            DisplayAlert("Exclusão", "Cliente excluído com sucesso!", "OK");
        }

        private void OnExcluirNaoClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a exclusão
            DisplayAlert("Exclusão", "Ação cancelada.", "OK");
        }

        private void OnAtualizarSimClicked(object sender, EventArgs e)
        {
            // Lógica para atualizar o cliente
            DisplayAlert("Atualização", "Cliente atualizado com sucesso!", "OK");
        }

        private void OnAtualizarNaoClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a atualização
            DisplayAlert("Atualização", "Ação cancelada.", "OK");
        }
    }
}
