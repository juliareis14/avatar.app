using System;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class BuscarCortePage : ContentPage
    {
        public BuscarCortePage()
        {
            InitializeComponent();
        }

        private async void OnExcluirClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Excluir?", "Deseja realmente excluir?", "Sim", "Não");
            if (answer)
            {
                // Lógica para excluir o item
            }
        }

        private async void OnAtualizarClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Atualizar?", "Deseja realmente atualizar?", "Sim", "Não");
            if (answer)
            {
                // Lógica para atualizar o item
            }
        }

        private async void OnAdicionarClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroCortePage());
        }

        private async void OnvoltarClicked(object sender, EventArgs e)
        {
              Navigation.PushAsync(new TelaEntrarPage());
        }
    }
}