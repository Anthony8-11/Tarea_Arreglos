using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsArreglos
    {
        private int [] ArregloTemporal;
        private string[] ArregloTemporalCadena;
        private int[] datos;
        private string[] datostring;
        private int i, j, datoTemporal;
        
        private string datotemporalCadena;
        private int tamanoArreglo = 0;

        //public int GetTamañoArreglo()
        //{
        //    return datos.Length;
        //}


        public ClsArreglos (int [] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length;  //Numero de datos
        }


        public ClsArreglos(string[] arreglo2)
        {
            datostring = arreglo2;
            tamanoArreglo = datostring.Length;  //Numero de datos

        }

        public ClsArreglos()
        {
        }



        /// <summary>
        /// Burbuja
        /// intercambiar cada pareja consecutiva no ordenada
        /// </summary>
        /// <returns></returns>


        public string[] MetodoBurbujaCadena()
        {
            ArregloTemporalCadena = datostring;
            

            for (i = 0; i < tamanoArreglo; i++)
            {
                for (j = i + 1; j < tamanoArreglo - 1; j++)
                {

                    if (ArregloTemporalCadena[i].CompareTo(ArregloTemporalCadena[j]) > 0)
                    {
                        datotemporalCadena = ArregloTemporalCadena[i];
                        ArregloTemporalCadena[i] = ArregloTemporalCadena[j];
                        ArregloTemporalCadena[j] = datotemporalCadena;
                    }

                }
            }
            return ArregloTemporalCadena;         

        }



        public int [] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j=i+1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] > ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }

                }
            }
            return ArregloTemporal;

        }


        public string[,] dosDimens(string[] arreglo, int numeroColumnas)
        {
            string[,] matriz = new string[arreglo.Length - 1, numeroColumnas];
            int contador = 0;
            foreach (string fila in arreglo)
            {
                if (contador > 0)
                {
                    string[] columnas = fila.Split(';');
                    matriz[contador - 1, 0] = columnas[0];
                    matriz[contador - 1, 1] = columnas[1];
                    matriz[contador - 1, 2] = columnas[2];
                    matriz[contador - 1, 3] = columnas[3];
                    matriz[contador - 1, 4] = columnas[4];
                    matriz[contador - 1, 5] = columnas[5];

                    int suma = Convert.ToInt16(columnas[2]) + Convert.ToInt16(columnas[3]) + Convert.ToInt16(columnas[4]);
                    int promedio = suma / 3;

                    matriz[contador - 1, 6] = Convert.ToString(promedio);
                }
                contador++;
            }
            return matriz;
        }


    }
}
