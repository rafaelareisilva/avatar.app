using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroEstampadorPage : ContentPage
    {
        public CadastroEstampadorPage()
        {
            InitializeComponent();
        }

        private void OnSelectNomeClicked(object sender, EventArgs e)
        {
            // Lógica para selecionar nome
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Cadastrar"
            string nome = NomeEntry.Text;
            string telefone = TelefoneEntry.Text;
            string endereco = EnderecoEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados do estampador
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }
    }
}
