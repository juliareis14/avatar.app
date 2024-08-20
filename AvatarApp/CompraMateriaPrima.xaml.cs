using System.Collections.Generic;
using AvatarApp.Modelos;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CompraMateriaPrima : ContentPage
    {
        Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
        Controles.CompraMpControle compraMpControle = new Controles.CompraMpControle();

        public CompraMateriaPrima()
        {
            InitializeComponent();
            pickerUnidade.ItemsSource = unidadeControle.LerTodos();
            pickerFornecedor.ItemsSource = fornecedorControle.LerTodos();
            pickerCompraMp.ItemsSource = compraMpControle.LerTodos();
            

           
            FinalizarButton.Clicked += OnFinalizarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnFinalizarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para finalizar a compra
            await DisplayAlert("Compra", "Compra finalizada com sucesso!", "OK");
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
