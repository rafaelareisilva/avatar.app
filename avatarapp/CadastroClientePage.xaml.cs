using System;
using avatarapp.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroClientePage : ContentPage
    {
        public Cliente cliente;
        ClienteControle clienteControle = new ClienteControle();
        public CadastroClientePage()
        {
            InitializeComponent();
        }

         protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                IdLabel.Text = cliente.Id.ToString();
                NomeEntry.Text = cliente.Nome;
                EnderecoEntry.Text = cliente.Endereco;
                TelefoneEntry.Text = cliente.Telefone;
            }
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            var c = new Cliente();
            c.Nome = NomeEntry.Text;
            c.Telefone = TelefoneEntry.Text;
            c.Endereco = EnderecoEntry.Text;

            clienteControle.CriarOuAtualizar(c);

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
