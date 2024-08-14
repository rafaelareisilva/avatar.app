using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroCompraMateriaPrima : ContentPage
    {
        public List<string> Unidades { get; set; }

        public CadastroCompraMateriaPrima()
        {
            InitializeComponent();

            Unidades = new List<string>
            {
                "Quilogramas",
                "Litros",
                "Unidades"
            };

            BindingContext = this;

            FinalizarButton.Clicked += OnFinalizarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnFinalizarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para finalizar a compra de matéria-prima
            await DisplayAlert("Compra", "Compra de matéria-prima finalizada com sucesso!", "OK");
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
