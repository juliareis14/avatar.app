using System;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class BuscarMateriaPrima : ContentPage
    {
        public BuscarMateriaPrima()
        {
            InitializeComponent();
        }

        private void Limpar_Clicked(object sender, EventArgs e)
        {
            txtBusca.Text = string.Empty; // Limpa o campo de texto
        }

        private async void Atualizar_Clicked(object sender, EventArgs e)
        {
            // Lógica para atualizar os resultados da pesquisa
            // ... (ex: chamar uma API, atualizar uma lista local, etc.)
            await DisplayAlert("Informação", "Resultados atualizados.", "OK");
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            // ... (ex: Navigation.PopAsync())
        }

        private void Adicionar_Clicked(object sender, EventArgs e)
        {
            // Lógica para adicionar uma nova matéria-prima
            // ... (ex: navegar para uma nova página de cadastro, abrir um modal, etc.)
        }
    }
}
