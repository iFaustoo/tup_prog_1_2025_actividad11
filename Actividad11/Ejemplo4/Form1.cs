using Ejemplo4.Models;
using System.Numerics;

namespace Ejemplo4
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            //acumulador += Convert.ToDouble( Console.ReadLine() );
            //acumulador += Convert.ToDouble(tbValor.Text);

            servicio.RegistrarValor(Convert.ToDouble(tbValor.Text));

            tbValor.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = servicio.CalcularPromedio();

            lbPromedio.Text = $"{promedio:f2}";

            tbPromedio.Text = $@"Promedio:

  {promedio,10:f2}";
        }



        private void btmOrdenar_Click(object sender, EventArgs e)
        {
            tbPromedio.Clear();

            servicio.Ordenar();

            for (int n = 0; n < servicio.Contador; n++)
            {
                tbPromedio.Text += $"{servicio.Valores[n],6:f2}";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            double valor= Convert.ToDouble(tbBuscar.Text);

            int idx=servicio.Buscar(valor);

            if (idx > -1)
            {
                tbPromedio.Text = $"Valor encontrador en la posición {idx}";
            }
            else 
            {
                tbPromedio.Text = "No lo encontró";
            } 
        }
    }
}
