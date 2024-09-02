using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarEstoquePage : ContentPage
    {
        public BuscarEstoquePage()
        {
            InitializeComponent();
        }

        private void OnExcluirClicked(object sender, EventArgs e)
        {
            excluirFrame.IsVisible = true;
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            atualizarFrame.IsVisible = true;
        }

        private void OnConfirmarExcluirClicked(object sender, EventArgs e)
        {
            // Lógica para excluir o item
            excluirFrame.IsVisible = false;
        }

        private void OnCancelarExcluirClicked(object sender, EventArgs e)
        {
            excluirFrame.IsVisible = false;
        }

        private void OnConfirmarAtualizarClicked(object sender, EventArgs e)
        {
            // Lógica para atualizar o item
            atualizarFrame.IsVisible = false;
        }

        private void OnCancelarAtualizarClicked(object sender, EventArgs e)
        {
            atualizarFrame.IsVisible = false;
        }

        private void OnAdicionarClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroEstoquePage());
        }

         private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
