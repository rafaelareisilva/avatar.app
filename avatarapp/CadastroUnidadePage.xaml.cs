using Controles;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroUnidadePage : ContentPage
    {
        UnidadeControle unidadeControle = new UnidadeControle();
        public CadastroUnidadePage()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            var u = new Unidade();
            u.Nome = NomeEntry.Text;

            unidadeControle.CriarOuAtualizar(u);
            // Lógica para o botão de adicionar
            // Pode ser utilizado para adicionar uma nova unidade ou qualquer outra lógica necessária
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Cadastrar"
            string nome = NomeEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados da unidade
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }
    }
}