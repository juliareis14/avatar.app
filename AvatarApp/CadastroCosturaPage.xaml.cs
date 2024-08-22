using System;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CadastroCosturaPage : ContentPage
    {
        Controles.CostureiraControle costureiraControle = new Controles.CostureiraControle();
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        public CadastroCosturaPage()
        {
            InitializeComponent();
             pickerCostureira.ItemsSource = costureiraControle.LerTodos();
             pickerProduto.ItemsSource = produtoControle.LerTodos();
        }
    }
}
