using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarCosturaPage : ContentPage
    {
        public BuscarCosturaPage()
        {
            InitializeComponent();
        }

        private void OnExcluirClicked(object sender, EventArgs e)
        {
            ExcluirFrame.IsVisible = true;
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            AtualizarFrame.IsVisible = true;
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new CadastroCosturaPage());
        }

        private void OnConfirmarExcluirClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar exclusão
            ExcluirFrame.IsVisible = false;
        }

        private void OnCancelarExcluirClicked(object sender, EventArgs e)
        {
            ExcluirFrame.IsVisible = false;
        }

        private void OnConfirmarAtualizarClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar atualização
            AtualizarFrame.IsVisible = false;
        }

        private void OnCancelarAtualizarClicked(object sender, EventArgs e)
        {
            AtualizarFrame.IsVisible = false;
        }

         private void Voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaEntrarPage());
        }
    }
}
