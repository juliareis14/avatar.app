using System;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class BuscarCortePage : ContentPage
    {
        public BuscarCortePage()
        {
            InitializeComponent();

            // Exemplo de como mostrar os frames ao clicar nos ícones (carrinho e refresh)
            var carrinhoTapGestureRecognizer = new TapGestureRecognizer();
            carrinhoTapGestureRecognizer.Tapped += (s, e) =>
            {
                excluirFrame.IsVisible = !excluirFrame.IsVisible;
            };
            var refreshTapGestureRecognizer = new TapGestureRecognizer();
            refreshTapGestureRecognizer.Tapped += (s, e) =>
            {
                atualizarFrame.IsVisible = !atualizarFrame.IsVisible;
            };

            carrinhoImage.GestureRecognizers.Add(carrinhoTapGestureRecognizer);
            refreshImage.GestureRecognizers.Add(refreshTapGestureRecognizer);
        }
    }
}
