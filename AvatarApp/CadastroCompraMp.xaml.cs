using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace AvatarApp
{
    public partial class CompraMateriaPrima : ContentPage
    {
        public List<string> Unidades { get; set; }

        public CompraMateriaPrima()
        {
            InitializeComponent();

            Unidades = new List<string>
            {
                "Quilogramas",
                "Litros",
                "Unidades"
            };

            BindingContext = this;

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
