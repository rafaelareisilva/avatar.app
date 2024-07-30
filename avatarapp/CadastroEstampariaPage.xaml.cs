using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroEstampariaPage : ContentPage
    {
        public CadastroEstampariaPage()
        {
            InitializeComponent();
        }

        private void OnSelectNomeClicked(object sender, EventArgs e)
        {
            // Lógica para selecionar nome
        }

        private void OnSelectProdutoClicked(object sender, EventArgs e)
        {
            // Lógica para selecionar produto
        }

        private void OnAddCaracteristicaClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar característica
        }

        private void OnDeleteCaracteristicaClicked(object sender, EventArgs e)
        {
            // Lógica para deletar característica
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Cadastrar"
            string nome = NomeEntry.Text;
            string produto = ProdutoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string entrada = EntradaEntry.Text;
            string prazo = PrazoEntry.Text;
            string cor = CorEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados de estamparia
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }
    }
}
