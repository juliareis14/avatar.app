using System;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class EstoquePage : ContentPage
    {
         Controles.CadastroMpControle cadastroMpControle = new Controles.CadastroMpControle();
         Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
        public EstoquePage()
        {
            InitializeComponent();
              pickerCadastroMp.ItemsSource = cadastroMpControle.LerTodos();
              pickerFornecedor.ItemsSource = fornecedorControle.LerTodos();

            AdicionarButton.Clicked += OnAdicionarButtonClicked;
        }

        private void OnAdicionarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar os dados
           
            string quantidade = QuantidadeEntry.Text;
            string entrada = EntradaEntry.Text;

            // Implementar a lógica de adicionar aqui

            DisplayAlert("Sucesso", "Estoque adicionado com sucesso", "OK");
        }
    }
}
