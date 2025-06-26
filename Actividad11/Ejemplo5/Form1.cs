namespace Ejemplo5
{
    public partial class Form1 : Form
    {
        int[] libretas;
        int[] nombres;
        int contador;
        int[] valores = { 1, 3, 7, 8, 9 };

        public Form1()
        {
            InitializeComponent();
        }


        int Buscar(int busqueda)
        {
           
            int cantidad = valores.Length;
            int idx = -1;
           


            int inicio = 0, fin = valores.Length - 1;

            while (idx == -1 && inicio<fin)
            {
                int medio = (inicio + fin) / 2;
                if (valores[medio] == busqueda)
                {
                    idx = medio;
                }
                else if (valores[medio] < busqueda)
                {
                    inicio = medio + 1;
                }
                else if (valores[medio] > busqueda)
                {
                    fin = medio - 1;
                }
            }

            return idx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int busqueda = Convert.ToInt32(tbBusqueda.Text);

            int idx = Buscar(busqueda);

            if (idx > -1)
                textBox1.Text = $"{idx}";
            else
                textBox1.Text = "no lo encontro";
        }
    }
}
