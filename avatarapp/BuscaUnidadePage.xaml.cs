using avatarapp.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarUnidadePage : ContentPage
    {
        UnidadeControle unidadeControle = new UnidadeControle();

        public BuscarUnidadePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            ListaUnidade.ItemsSource = unidadeControle.LerTodos();
        }
          async void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastroUnidadePage();
            page.unidade = e.SelectedItem as Unidade;
            await Navigation.PushAsync(page);
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