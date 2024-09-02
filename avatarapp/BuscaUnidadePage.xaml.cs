using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarUnidadePage : ContentPage
    {
        public BuscarUnidadePage()
        {
            InitializeComponent();
        }

        private void OnSearchButtonClicked(object sender, EventArgs e)
        {
            // Lógica para buscar unidade
        }

        private void OnRefreshButtonClicked(object sender, EventArgs e)
        {
            // Lógica para atualizar a busca
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new TelaEntrarPage());
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroUnidadePage());
        }
    }
}
