using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateware.Negocio
{
    public class Exercicio01
    {
        public static int Solucao01()
        {
            try
            {
                int maiorNumero = 0;
                List<int> lstNumero = new List<int>();

                for (int contador = 0; contador != 500; contador++)
                {
                    lstNumero.Add(new Random().Next(100, 100000));

                    //Congelando por 1 milisegundos
                    System.Threading.Thread.Sleep(1);
                }

                for (int contador = 0; contador != lstNumero.Count; contador++)
                {
                    if (lstNumero[contador] > maiorNumero)
                    {
                        maiorNumero = lstNumero[contador];
                    }
                }

                return maiorNumero;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public static int Solucao02()
        {
            try
            {
                int maiorNumero = 0;
                int numero = 0;
                List<int> lstNumero = new List<int>();

                for (int contador = 0; contador != 500; contador++)
                {
                    numero = new Random().Next(100, 100000);
                    if (numero > maiorNumero)
                    {
                        maiorNumero = numero;
                    }

                    //Congelando por 1 milisegundos
                    System.Threading.Thread.Sleep(1);
                }
                return maiorNumero;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
