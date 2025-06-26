using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models
{
    internal class Servicio
    {
        public double[] Valores = new double[100];
        public int Contador = 0;

        public void RegistrarValor(double valor)
        {
            Valores[Contador] = valor;
            Contador++;
        }

        public double CalcularPromedio()
        {
            double acumulador = 0;

            for (int n = 0; n < Contador; n++)
            {
                acumulador += Valores[n];
            }

            double promedio = acumulador / Contador;
            return promedio;
        }

        public void Ordenar()
        {
            for (int piv = 0; piv < Contador - 1; piv++)
            {
                for (int comp = piv + 1; comp < Contador; comp++)
                {
                    if (Valores[piv] > Valores[comp])
                    {
                        Intercambio(Valores, piv, comp);
                    }
                }
            }
        }

        void Intercambio(double[] vector, int a, int b)
        {
            double tmp = Valores[a];
            Valores[a] = Valores[b];
            Valores[b] = tmp;
        }

        public int Buscar(double valor)
        {
            int idx=-1;

            int n = 0;
            while (n<Contador && idx==-1)
            {
                if (valor == Valores[n])
                {
                    idx = n;
                }
                n++;
            }

            return idx;
        }
    }
}
