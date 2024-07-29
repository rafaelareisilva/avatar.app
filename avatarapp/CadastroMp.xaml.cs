using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        public List<string> Unidades { get; set; }

        public CadastroMateriaPrima()
        {
            InitializeComponent();

            Unidades = new List<string>
            {
                "Quilogramas",
                "Litros",
                "Unidades"
            };

            BindingContext = this;

            CadastrarButton.Clicked += OnCadastrarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnCadastrarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar a matéria-prima
            await DisplayAlert("Cadastro", "Matéria-prima cadastrada com sucesso!", "OK");
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
