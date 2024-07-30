using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarProduto : ContentPage
    {
        public BuscarProduto()
        {
            InitializeComponent();
        }

        private void Limpar_Clicked(object sender, EventArgs e)
        {
            txtBusca.Text = string.Empty; // Limpa o campo de texto
        }

        private async void Atualizar_Clicked(object sender, EventArgs e)
        {
            // Lógica para atualizar os resultados da pesquisa
            // ... (ex: chamar uma API, atualizar uma lista local, etc.)
            await DisplayAlert("Informação", "Resultados atualizados.", "OK");
        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            // ... (ex: Navigation.PopAsync())
            bool answer = await DisplayAlert("Apagar?", "Tem certeza que deseja apagar?", "Sim", "Não");
        }

        private void Adicionar_Clicked(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo produto
            // ... (ex: navegar para uma nova página de cadastro, abrir um modal, etc.)
        }
    }
}
