using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kIzaExamen1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string total)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtTotal.Text = total;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
         
        }

        private void btnAcerca_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Realizado por ", "KAROL ALEJANDRA IZA LOACHAMIN", "ACEPTAR");
        }
    }
}