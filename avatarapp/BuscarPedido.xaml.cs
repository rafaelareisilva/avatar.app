using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarPedido : ContentPage
    {
        public BuscarPedido()
        {
            InitializeComponent();
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            // ... (ex: Navigation.PopAsync())
        }

        private void Buscar_Clicked(object sender, EventArgs e)
        {
            // Lógica para realizar a busca
            var pedidoBuscado = ((Entry)sender).Text;
            // ... (ex: consultar um banco de dados, exibir resultados em uma lista)
        }

        private void Adicionar_Clicked(object sender, EventArgs e)
        {
            // Lógica para a ação do botão "+"
            // ... (ex: abrir um modal para adicionar um novo pedido, filtrar resultados, etc.)
        }
    }
}
