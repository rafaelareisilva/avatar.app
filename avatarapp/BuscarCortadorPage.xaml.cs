using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarCortadorPage : ContentPage
    {
        public BuscarCortadorPage()
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
            // Lógica para adicionar novo cortador
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
    }
}
