using AvatarApp.Modelos;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CadastroPedidoPage : ContentPage
    {
          Controles.ClienteControle clienteControle = new Controles.ClienteControle();
          Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        public CadastroPedidoPage()
        {
            InitializeComponent();
            pickerPedido.ItemsSource = clienteControle.LerTodos();
            pickerPedido.ItemsSource = unidadeControle.LerTodos();
        }

        private void OnSelectClienteClicked(object sender, EventArgs e)
        {
            // Lógica para selecionar cliente
        }

        private void OnSelectUnidadeMedidaClicked(object sender, EventArgs e)
        {
            // Lógica para selecionar unidade de medida
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            var p =new Pedido();
            p.Cliente = pickerPedido.SelectedItem as Cliente;

            // Lógica para o botão "Cadastrar"
            
            string telefone = TelefoneEntry.Text;
            string produto = ProdutoEntry.Text;
            string valor = ValorEntry.Text;
            string desconto = DescontoEntry.Text;
            string prazo = PrazoEntry.Text;
            string total = TotalEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados do pedido
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }
    }
}
