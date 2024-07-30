using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }

        private void OnAddMateriaPrimaClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar matéria prima
        }

        private void OnDeleteMateriaPrimaClicked(object sender, EventArgs e)
        {
            // Lógica para deletar matéria prima
        }

        private void OnSelectUnidadeClicked(object sender, EventArgs e)
        {
            // Lógica para selecionar unidade
        }

        private void OnFinalizarCadastroClicked(object sender, EventArgs e)
        {
            // Lógica para finalizar cadastro
            string nome = NomeEntry.Text;
            string telefone = TelefoneEntry.Text;
            string produto = ProdutoEntry.Text;
            string unidade = UnidadeEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados do fornecedor
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de deletar
        }

        private void OnRefreshClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de refresh
        }
    }
}
