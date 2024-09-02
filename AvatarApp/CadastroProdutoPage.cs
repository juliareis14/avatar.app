using System;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CadastroProdutoPage : ContentPage
    {
        Controles.UnidadeControle produtoControle = new Controles.UnidadeControle();
        public CadastroProdutoPage()
        {
            InitializeComponent();
            pickerProduto.ItemsSource = produtoControle.LerTodos();
        }

         private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
