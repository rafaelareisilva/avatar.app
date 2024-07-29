using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroFornecedor : ContentPage
    {
        public List<string> Unidades { get; set; }

        public CadastroFornecedor()
        {
            InitializeComponent();

            Unidades = new List<string>
            {
                "Unidade 1",
                "Unidade 2",
                "Unidade 3"
            };

            BindingContext = this;

            FinalizarButton.Clicked += OnFinalizarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnFinalizarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para finalizar o cadastro
            await DisplayAlert("Cadastro", "Cadastro finalizado com sucesso!", "OK");
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
