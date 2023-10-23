using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAltura.Text) && !string.IsNullOrEmpty(txtPeso.Text))
            {
                calcularAP();
            }
            else
            {
                DisplayAlert("Datos vacios", "LLenar los campos vacios", "OK");
            }
        }
        public void calcularAP()
        {
            double altura = Convert.ToDouble(txtAltura.Text);
            double peso = Convert.ToDouble(txtPeso.Text);
            double resultados = peso / (altura * altura);
            txtResultado.Text = resultados.ToString();
            string mensaje = "";
            if (resultados < 18.5)
            {
                mensaje = "Tiene bajo peso";
            }
            else if (resultados >= 18.5 && resultados <= 24.6)
            {
                mensaje = "Tu peso es normal";
            }
            else if (resultados >= 25 && resultados <= 29.9)
            {
                mensaje = "Tienes sombrero";
            }
            else
            {
                mensaje = "Tiene Sobrepeso";
            }
            DisplayAlert("Resultados", mensaje, "OK");

        }
    }
}
