using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarEstampariaPage : ContentPage
    {
        public BuscarEstampariaPage()
        {
            InitializeComponent();
        }

        private void OnSearchButtonClicked(object sender, EventArgs e)
        {
            // Lógica para buscar estamparia
        }

        private void OnRefreshButtonClicked(object sender, EventArgs e)
        {
            AtualizarFrame.IsVisible = true;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar uma nova estamparia
        }

        private void OnConfirmDeleteButtonClicked(object sender, EventArgs e)
        {
            ExcluirFrame.IsVisible = false;
            // Lógica para confirmar exclusão
        }

        private void OnCancelDeleteButtonClicked(object sender, EventArgs e)
        {
            ExcluirFrame.IsVisible = false;
        }

        private void OnConfirmUpdateButtonClicked(object sender, EventArgs e)
        {
            AtualizarFrame.IsVisible = false;
            // Lógica para confirmar atualização
        }

        private void OnCancelUpdateButtonClicked(object sender, EventArgs e)
        {
            AtualizarFrame.IsVisible = false;
        }
    }
}