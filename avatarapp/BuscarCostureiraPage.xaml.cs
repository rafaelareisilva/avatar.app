using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarCostureiraPage : ContentPage
    {
        public BuscarCostureiraPage()
        {
            InitializeComponent();
        }

        private void OnSearchButtonClicked(object sender, EventArgs e)
        {
            // Lógica para buscar costureira
        }

        private void OnRefreshButtonClicked(object sender, EventArgs e)
        {
            // Lógica para atualizar a busca
            AtualizarFrame.IsVisible = true; // Exibir frame de confirmação de atualização
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new TelaEntrarPage());
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroCostureiraPage());
        }

        private void OnExcluirSimClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar exclusão
            ExcluirFrame.IsVisible = false; // Ocultar frame de confirmação
        }

        private void OnExcluirNaoClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar exclusão
            ExcluirFrame.IsVisible = false; // Ocultar frame de confirmação
        }

        private void OnAtualizarSimClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar atualização
            AtualizarFrame.IsVisible = false; // Ocultar frame de confirmação
        }

        private void OnAtualizarNaoClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar atualização
            AtualizarFrame.IsVisible = false; // Ocultar frame de confirmação
        }
    }
}