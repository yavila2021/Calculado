using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        private object numero_1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void suma_Clicked(object sender, EventArgs e)
        {
            object numero_11 = null;
            int n1 = Convert.ToInt32 (numero_11.Text);
            int n2 = Convert.ToInt32(numero_2.Text);
            int suma = n1 + n2;
            object total = null;
            total = suma;
        }

        private void resta_Clicked(object sender, EventArgs e)
        {

        }

        private void divicion_Clicked(object sender, EventArgs e)
        {

        }

        private void multiplicacion_Clicked(object sender, EventArgs e)
        {

        }
    }
}
