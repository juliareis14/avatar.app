using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class BuscarCosturaPage : ContentPage
    {
        public BuscarCosturaPage()
        {
            InitializeComponent();
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            ExcluirFrame.IsVisible = true;
        }

        private void OnUpdateClicked(object sender, EventArgs e)
        {
            AtualizarFrame.IsVisible = true;
        }

        private void OnConfirmDeleteClicked(object sender, EventArgs e)
        {
            ExcluirFrame.IsVisible = false;
            // Lógica para excluir o item
        }

        private void OnCancelDeleteClicked(object sender, EventArgs e)
        {
            ExcluirFrame.IsVisible = false;
        }

        private void OnConfirmUpdateClicked(object sender, EventArgs e)
        {
            AtualizarFrame.IsVisible = false;
            // Lógica para atualizar o item
        }

        private void OnCancelUpdateClicked(object sender, EventArgs e)
        {
            AtualizarFrame.IsVisible = false;
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo item
        }
    }
}
