namespace Ejemplo3
{
    public partial class Form1 : Form
    {
        double[] valores = new double[100];
        int contador = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            //acumulador += Convert.ToDouble( Console.ReadLine() );
            //acumulador += Convert.ToDouble(tbValor.Text);

            valores[contador] = Convert.ToDouble(tbValor.Text);
            contador++;


            tbValor.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double acumulador = 0;

            for (int n = 0; n < contador; n++)
            {
                acumulador += valores[n];
            }

            double promedio = acumulador / contador;

            lbPromedio.Text = $"{promedio:f2}";

            tbPromedio.Text = $@"Promedio:

  {promedio,10:f2}";
        }

       
    }
}
