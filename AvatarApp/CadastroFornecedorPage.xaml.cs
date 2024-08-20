using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        Controles.UnidadeControle produtoControle = new Controles.UnidadeControle();
        public List<string> Unidades { get; set; }

        public CadastroFornecedorPage()
        {
            InitializeComponent();

            pickerUnidade.ItemsSource = unidadeControle.LerTodos();
            pickerProduto.ItemsSource = produtoControle.LerTodos();



            FinalizarButton.Clicked += OnFinalizarButtonClicked;
            VoltarButton.Clicked += OnVoltarButtonClicked;
        }

        private async void OnFinalizarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para finalizar o cadastro
            await DisplayAlert("Cadastro", "Cadastro finalizado com sucesso!", "OK");
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            await Navigation.PopAsync();
        }
    }
}
