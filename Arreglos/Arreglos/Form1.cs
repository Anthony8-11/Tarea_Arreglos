using Arreglos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {

        private string[] ArregloNotas;
        ClsArreglos arreglo = new ClsArreglos();
        ClsPromedios promedio = new ClsPromedios();


        public Form1()
        {
            InitializeComponent();
        }

        public string[,] matriz;
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();

            ArregloNotas = ar.LeerArchivo(ar.ruta);
            ArregloNotas = ar.getFilas();

            string[] filas = ar.getFilas();

            foreach (string lineas in filas)
            {
                listBoxNom.Items.Add(lineas);
                
            }

            matriz = arreglo.dosDimens(filas, 7);
        }


        private void buttonNombres_Click(object sender, EventArgs e)
        {

            listBoxResultado.Items.Clear();


            string[] nombres = new string[ArregloNotas.GetLength(0) - 1];
            int contador = 0;
            foreach(string linea in ArregloNotas)
            {
                string[] columnas = linea.Split(';');
                if (contador != 0)
                {
                    nombres[contador - 1] = columnas[1];//COLUMNA 1 SON LOS NOMBRES
                }
                contador++;
            }

            ClsArreglos metodo = new ClsArreglos(nombres);
            string[] datos = metodo.MetodoBurbujaCadena();
            

            foreach (string nombre in datos)
            {
                listBoxResultado.Items.Add(nombre);
            }

        }



        public int promedios(string[,] matriz, int columna)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);

            }
            promedio = acumulador / (matriz.GetLength(0) - 1);
            return promedio;

        }
        
        private void buttonProm1_Click(object sender, EventArgs e)
        {

            listBoxDatos.Items.Clear();

            int contador = 0;
            int promedio, acumulador;
            acumulador = 0;


            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length,5];

            int[] ordenParcial = new int[ArregloNotas.Length - 1];


            
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (contador != 0)
                {


                    acumulador = acumulador + Convert.ToInt32(datos[2]);
                    ordenParcial[contador - 1] = Convert.ToInt32(datos[2]);

                }
                ArregloDosDimensiones[contador, 0] = datos[0];
                ArregloDosDimensiones[contador, 1] = datos[1];
                ArregloDosDimensiones[contador, 2] = datos[2];
                ArregloDosDimensiones[contador, 3] = datos[3];
                ArregloDosDimensiones[contador, 4] = datos[4];
                contador++; 

            }

            ClsArreglos fncArroglos = new ClsArreglos(ordenParcial);
            ordenParcial = fncArroglos.MetodoBurbuja();
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length - 1];
            
            

            promedio = acumulador / contador - 1;

            int promedioMatriz = promedios(ArregloDosDimensiones, 2);

            listBoxDatos.Items.Add($"Promedio es {promedio}");
            listBoxDatos.Items.Add($"Min={min}");
            listBoxDatos.Items.Add($"Max={max}");
            listBoxDatos.Items.Add($"Promedio matriz={promedioMatriz}");

        }


        private void buttonPromAlum_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                listBoxResultado.Items.Add(matriz[i, 1] + "  /* Promedio: " + matriz[i, 6]);
            }
        }

        private void buttonPromI_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Clear();

            int datos = promedio.promedios_por_parcial(matriz, 2);
            listBoxDatos.Items.Add("Promedio Parcial I: " + datos);

        }

        private void buttonPromII_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Clear();

            int datos = promedio.promedios_por_parcial(matriz, 3);
            listBoxDatos.Items.Add("Promedio Parcial II: " + datos);
        }

        private void buttonPromIII_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Clear();

            int datos = promedio.promedios_por_parcial(matriz, 4);
            listBoxDatos.Items.Add("Promedio Parcial III: " + datos);
        }



        private void buttonSumatoria_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            string[,] datos = promedio.sumatoria_general_por_alumno(matriz);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                listBoxResultado.Items.Add(datos[i, 0] + " /* Sumatoria: " + datos[i, 1]);
            }
        }

        private void buttonProGene_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Clear();
            string sect = textBoxSec.Text;
            int datos = promedio.promedios_por_seccion(matriz, 6, sect);
            listBoxDatos.Items.Add("Promedio General Seccion " + sect + " :" + datos);
        }




        private void buttonPromSecI_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Clear();
            string sect = textBoxSec.Text;
            int datos = promedio.promedios_por_seccion(matriz, 2, sect);
            listBoxDatos.Items.Add("Promedio General Parcial I Sección " + sect + " : " + datos);
        }

        private void buttonPromSecII_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Clear();
            string sect = textBoxSec.Text;
            int datos = promedio.promedios_por_seccion(matriz, 3, sect);
            listBoxDatos.Items.Add("Promedio General Parcial II Sección " + sect + " :" + datos);
        }

        private void buttonPromSecIII_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Clear();
            string sect = textBoxSec.Text;
            int datos = promedio.promedios_por_seccion(matriz, 4, sect);
            listBoxDatos.Items.Add("Promedio General Parcial III Sección " + sect + " :" + datos);
        }

        private void buttonClasificAlumxSec_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            string sect = this.textBoxSec.Text;
            string[,] datos = promedio.Clasificar_Alumnos(matriz, sect);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                listBoxResultado.Items.Add(datos[i, 0] + "; " + datos[i, 1] + " / " + datos[i, 2] + " / " + datos[i, 3] + " / " + datos[i, 4] + " / " + datos[i, 5] + " / " + datos[i, 6]);
            }
        }
    }
    
}
