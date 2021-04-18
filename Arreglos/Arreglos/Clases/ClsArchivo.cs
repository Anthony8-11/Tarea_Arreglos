using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos.Clases
{
    class ClsArchivo
    {
        public string ruta;
        public string[] filas;

        public ClsArchivo()
        {
            OpenFile();
        }


        private string OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ruta = ofd.FileName;

            }
            return ruta;
        }

        public string[] getFilas()
        {
            string[] filas = File.ReadAllLines(ruta, Encoding.ASCII);
            this.filas = filas;
            return filas;
        }


        public string[] LeerArchivo(String archivo)
        {
            String[] lineas = File.ReadAllLines(archivo);
            return lineas;

        }

    }
}
