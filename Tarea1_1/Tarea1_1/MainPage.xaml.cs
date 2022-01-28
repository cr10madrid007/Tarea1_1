using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        

        private async void btnSumar_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.Procesos
            {
                Resultado = Convert.ToInt32(this.txtN1.Text) + Convert.ToInt32(this.txtN2.Text)

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);
        }

        private async void btnRestar_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.Procesos
            {
                Resultado = Convert.ToInt32(this.txtN1.Text) - Convert.ToInt32(this.txtN2.Text)

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);

        }

        private async void btnDividir_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.Procesos
            {
                Resultado = Convert.ToInt32(this.txtN1.Text) / Convert.ToInt32(this.txtN2.Text)

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);
        }

        private async void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.Procesos
            {
                Resultado = Convert.ToInt32(this.txtN1.Text) * Convert.ToInt32(this.txtN2.Text)

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);
        }
    }
}
