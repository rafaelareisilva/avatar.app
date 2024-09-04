using avatarapp.Modelos;
using Controles;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroUnidadePage : ContentPage
    {
         public Unidade unidade;
         UnidadeControle unidadeControle = new UnidadeControle();
        public CadastroUnidadePage()
        {
            InitializeComponent();
        
        }
                protected override void OnAppearing()
        {
            base.OnAppearing();

            if (unidade != null)
            {
                IdLabel.Text = unidade.Id.ToString();
                NomeEntry.Text = unidade.Nome;
                
            }
        }



        private void OnCadastrarClicked(object sender, EventArgs e)
         {
            //if (await VerificaSeDadosEstaoCorretos())
            {
                var unidade = new Unidade(); // Usando 'Cliente' com maiúscula
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    unidade.Id = int.Parse(IdLabel.Text);
                else
                    unidade.Id = 0;
                unidade.Nome = NomeEntry.Text;
                unidadeControle.CriarOuAtualizar(unidade); // Adicionado 'await' e corrigido 'CriarOuAtualizar'

            }
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }

          private async void OnApagarClienteClicked(object sender, EventArgs e)
  {
   
    if (unidade == null || unidade.Id < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
     
      unidadeControle.Apagar(unidade.Id);
      
      Application.Current.MainPage = new BuscarUnidadePage(); 
    }
  }
    }
}