using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    internal class Logica
    {
        static string[,] reserva = new string[3, 3];

        public static void inicializar()
        {
            for (int i = 0; i < reserva.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    reserva[i, j] = "";
                }
            }
        }

        public static Boolean cancelar( string nombre)
        {

            Boolean cancelacion = false;
            for (int i = 0; i < reserva.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (nombre.Equals(reserva[i,j]))
                    {
                        reserva[i, j] = "";
                        cancelacion = true; 
                    }
                    
                }
            }

            return cancelacion;
        }
        public static Boolean asientoReserva(int fila, int col, string nombre)
        {
            if (reserva[fila, col].Equals(""))
            {
                reserva[fila, col] = nombre;
                return true;
            }
            else
            {
               return false;
            }
            

        }
    }
}