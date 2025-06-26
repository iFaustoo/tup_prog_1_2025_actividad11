namespace Ejemplo2
{
    public partial class FormPrincipal : Form
    {
        double acumulador = 0;
        int contador = 0;


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            //acumulador += Convert.ToDouble( Console.ReadLine() );
            acumulador += Convert.ToDouble(tbValor.Text);
            contador++;


            tbValor.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;

            lbPromedio.Text = $"{promedio:f2}";

            tbPromedio.Text = $@"Promedio:

  {promedio,10:f2}";
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
