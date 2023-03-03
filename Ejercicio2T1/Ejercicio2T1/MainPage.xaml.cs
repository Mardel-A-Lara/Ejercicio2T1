using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2T1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void btnsuma_Clicked(object sender, EventArgs e)
        {

            var datos = new Class1
            {

                Resultado = int.Parse(txtn1.Text) + int.Parse(txtn2.Text),

            };

            var secondpage = new Pagemostrar();
            secondpage.BindingContext = datos;
            Navigation.PushAsync(secondpage);

        }

        private void btnresta_Clicked(object sender, EventArgs e)
        {
            var datos = new Class1
            {

                Resultado = int.Parse(txtn1.Text) - int.Parse(txtn2.Text),

            };

            var secondpage = new Pagemostrar();
            secondpage.BindingContext = datos;
            Navigation.PushAsync(secondpage);

        }

        private void btndividir_Clicked(object sender, EventArgs e)
        {
            var datos = new Class1
            {

                Resultado = double.Parse(txtn1.Text) / double.Parse(txtn2.Text),

            };

            var secondpage = new Pagemostrar();
            secondpage.BindingContext = datos;
            Navigation.PushAsync(secondpage);

        }

        private void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            var datos = new Class1
            {

                Resultado = int.Parse(txtn1.Text) * int.Parse(txtn2.Text),

            };

            var secondpage = new Pagemostrar();
            secondpage.BindingContext = datos;
            Navigation.PushAsync(secondpage);

        }


    }
}
