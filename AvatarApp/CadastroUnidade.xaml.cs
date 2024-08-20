using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CadastroUnidadePage : ContentPage
    {
        public CadastroUnidadePage()
        {
            InitializeComponent();
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
