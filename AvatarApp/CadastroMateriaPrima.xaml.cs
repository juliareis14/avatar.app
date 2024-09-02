using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        
        Controles.UnidadeControle uniadadeControle = new Controles.UnidadeControle();

        public CadastroMateriaPrima()
        {
            InitializeComponent();

         

            CadastrarButton.Clicked += OnCadastrarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnCadastrarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar a matéria-prima
            await DisplayAlert("Cadastro", "Matéria-prima cadastrada com sucesso!", "OK");
         
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
