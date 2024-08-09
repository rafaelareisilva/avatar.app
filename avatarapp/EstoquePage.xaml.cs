using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class EstoquePage : ContentPage
    {
        public EstoquePage()
        {
            InitializeComponent();

            AdicionarButton.Clicked += OnAdicionarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
            SimButton.Clicked += OnSimButtonClicked;
            NaoButton.Clicked += OnNaoButtonClicked;
        }

        private void OnAdicionarButtonClicked(object sender, EventArgs e)
        {
            // Exibe a frame de confirmação
            ConfirmacaoFrame.IsVisible = true;
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Volta para a página anterior
            Navigation.PopAsync();
        }

        private void OnSimButtonClicked(object sender, EventArgs e)
        {
            // Implementa a lógica de adicionar o item ao estoque
            // Esconde a frame de confirmação após a adição
            ConfirmacaoFrame.IsVisible = false;
        }

        private void OnNaoButtonClicked(object sender, EventArgs e)
        {
            // Esconde a frame de confirmação sem adicionar o item
            ConfirmacaoFrame.IsVisible = false;
        }
    }
}

