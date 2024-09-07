namespace FormulaCuadratica
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void txtCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {

                if (Validar())
                {
                    double a, b, c, discriminante;
                    double x1, x2;

                    a = double.Parse(txtA.Text);
                    b = double.Parse(txtB.Text);
                    c = double.Parse(txtC.Text);

                    if (a == 0)
                    {
                        DisplayAlert("Advertencia", "El valor de a no puede ser igual a cero", "Aceptar");
                    }
                    else
                    {
                        discriminante = Math.Pow(b, 2) - (4 * a * c);

                        if (discriminante >= 0)
                        {
                            x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                            x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                            txtX1.Text = x1.ToString();
                            txtX2.Text = x2.ToString();

                        }
                        else
                        {
                            DisplayAlert("Advertencia", "La raiz cuadrada no puede ser negativa", "Aceptar");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }

        private void txtLimpiar_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
        }

        private bool Validar()
        {
            bool esValido = true;

            if (txtA.Text == "" || txtA.Text is null)
            {
                Warning("Ingrese valor de a");
                esValido = false;
                txtA.Focus();
            }
            else if (txtB.Text == "" || txtB.Text is null)
            { 
                Warning("Ingrese valor de b");
                esValido = false;
                txtB.Focus();
            }
            else if (txtC.Text == "" || txtC.Text is null)
            {
                Warning("Ingrese valor de c");
                esValido = false;
                txtC.Focus();

            } 
                return esValido;

        }
        
        private void Warning(string mensaje)
        {
            DisplayAlert("Advertencia", mensaje, "Aceptar");
        }
    }

}
