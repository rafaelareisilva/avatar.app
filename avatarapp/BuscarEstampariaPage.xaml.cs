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

        

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new TelaEntrarPage());
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroEstampariaPage());
        }

        

        


    }
}