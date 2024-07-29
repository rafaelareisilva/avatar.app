using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroCortador : ContentPage
    {
        public CadastroCortador()
        {
            InitializeComponent();
        }

        private async void Cadastrar_Clicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar o cortador
            // ... (ex: coletar os dados dos campos, enviar para um banco de dados, etc.)

            await DisplayAlert("Sucesso", "Cortador cadastrado com sucesso!", "OK");
            // Navegar para outra página ou realizar alguma outra ação após o cadastro
        }
    }
}
