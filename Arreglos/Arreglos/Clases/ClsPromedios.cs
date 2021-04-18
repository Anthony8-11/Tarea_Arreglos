using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsPromedios : InterfacePromedio
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string sect)
        {
            int alumnosSeccion = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == sect)
                {
                    alumnosSeccion++;
                }
            }
            string[,] datos = new string[alumnosSeccion, matriz.GetLength(1)];
            int contNvMatriz = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == sect)
                {
                    datos[contNvMatriz, 0] = matriz[i, 0];
                    datos[contNvMatriz, 1] = matriz[i, 1];
                    datos[contNvMatriz, 2] = matriz[i, 2];
                    datos[contNvMatriz, 3] = matriz[i, 3];
                    datos[contNvMatriz, 4] = matriz[i, 4];
                    datos[contNvMatriz, 5] = matriz[i, 5];
                    datos[contNvMatriz, 6] = matriz[i, 6];
                    contNvMatriz++;
                }
            }
            return datos;
        }

        public int promedios_general_seccion(string[,] matriz, int columParcial, string sect)
        {
            int suma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == sect)
                {
                    suma = suma + Convert.ToInt32(matriz[i, columParcial]);
                }
            }
            int promedio = suma / matriz.GetLength(0);
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columParcial)
        {
            int acumulador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[i, columParcial]);
            }

            int promedio = acumulador / matriz.GetLength(0);

            return promedio;
        }

        public int promedios_por_seccion(string[,] matriz, int columParcial, string sect)
        {
            int acumulador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == sect)
                {
                    acumulador = acumulador + Convert.ToInt32(matriz[i, columParcial]);
                }
            }

            int promedio = acumulador / matriz.GetLength(0);

            return promedio;
        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            string[,] datos = new string[matriz.GetLength(0), 2];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                datos[i, 0] = matriz[i, 1];
                int suma = Convert.ToInt16(matriz[i, 2]) + Convert.ToInt16(matriz[i, 3]) + Convert.ToInt16(matriz[i, 4]);
                datos[i, 1] = Convert.ToString(suma);
            }
            return datos;
        }
    }
}
