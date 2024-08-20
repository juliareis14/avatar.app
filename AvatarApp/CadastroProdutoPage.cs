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
    }
}
