using System;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class BuscarPedido : ContentPage
    {
        public BuscarPedido()
        {
            InitializeComponent();
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new TelaEntrarPage());
        }

        private void Buscar_Clicked(object sender, EventArgs e)
        {
            // Lógica para realizar a busca
            var pedidoBuscado = ((Entry)sender).Text;
            // ... (ex: consultar um banco de dados, exibir resultados em uma lista)
        }

        private void Adicionar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPedidoPage());
        }
    }
}
