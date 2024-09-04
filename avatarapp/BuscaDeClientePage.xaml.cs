using avatarapp.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscaDeClientePage : ContentPage
    {
         Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public BuscaDeClientePage()
        {
            InitializeComponent();
             
        }
        
       


        private void OnSearchButtonClicked(object sender, EventArgs e)
        {
            // Lógica para buscar cliente
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
            Navigation.PushAsync(new CadastroClientePage());
        }
         async void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastroClientePage();
            page.cliente = e.SelectedItem as Cliente;
            await Navigation.PushAsync(page);
        }
    }
}
