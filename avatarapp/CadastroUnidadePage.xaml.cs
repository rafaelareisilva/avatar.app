using avatarapp.Modelos;
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

    
        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Cadastrar"
            
            var u = new Unidade();
            u.Nome = NomeEntry.Text;

            unidadeControle.CriarOuAtualizar(u);

            // Aqui você pode adicionar a lógica para salvar os dados da unidade
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }
    }
}