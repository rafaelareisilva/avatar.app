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
        }

        private void OnAdicionarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar os dados
            string materiaPrima = MateriaPrimaPicker.SelectedItem?.ToString();
            string fornecedor = FornecedorPicker.SelectedItem?.ToString();
            string quantidade = QuantidadeEntry.Text;
            string entrada = EntradaEntry.Text;

            // Implementar a lógica de adicionar aqui

            DisplayAlert("Sucesso", "Estoque adicionado com sucesso", "OK");
        }
    }
}
