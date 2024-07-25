using Microsoft.Maui.Controls;

namespace SeuNamespace
{
    public partial class CadastroClientePage : ContentPage
    {
        public CadastroClientePage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Cadastrar"
            string nome = NomeEntry.Text;
            string telefone = TelefoneEntry.Text;
            string endereco = EnderecoEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados do cliente
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }
    }
}
